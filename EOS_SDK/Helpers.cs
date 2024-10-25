using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace EOS_SDK;

public static class Helpers
{
    /// <summary>
    /// Making a String to IntPtr
    /// <br>Also Allocating for Null Bytes and encoding as UTF-8</br>
    /// </summary>
    /// <param name="str">The String</param>
    /// <returns>Allocated Pointer</returns>
    public static IntPtr FromString(this string str)
    {
        var bytes = Encoding.UTF8.GetBytes(str);
        var result_bytes = bytes.Concat(new byte[] { 0x00 }).ToArray();
        var PTR = Marshal.AllocHGlobal(bytes.Length + 1);
        Marshal.Copy(result_bytes, 0, PTR, result_bytes.Length);
        return PTR;
    }

    /// <summary>
    /// Making the Allocated Pointer back to String
    /// </summary>
    /// <param name="source">The Allocated Pointer</param>
    /// <returns>The String if exist of Empty</returns>
    public static string ToUTF8String(this IntPtr source)
    {
        if (source == IntPtr.Zero)
        {
            return string.Empty;
        }

        // C style strlen
        int length = source.GetStringLength();

        // +1 byte for the null terminator.
        byte[] bytes = new byte[length + 1];
        Marshal.Copy(source, bytes, 0, length + 1);
        return Encoding.UTF8.GetString(bytes);
    }

    /// <summary>
    /// Getting String Length
    /// </summary>
    /// <param name="address">Address of the String</param>
    /// <returns>Length of the String</returns>
    public static int GetStringLength(this IntPtr address)
    {
        if (address == IntPtr.Zero)
            return 0;
        int length = 0;
        while (Marshal.ReadByte(address, length) != 0)
        {
            ++length;
        }

        return length;
    }

    /// <summary>
    /// Converting Any Array to IntPtr
    /// </summary>
    /// <typeparam name="T">Any Type</typeparam>
    /// <param name="array">The Array</param>
    /// <returns>Allocated Pointer</returns>
    public static IntPtr FromStructArray<T>(this T[] array)
    {
        var IsNotValueType = !typeof(T).IsValueType;
        int SizeOfT;
        if (IsNotValueType)
        {
            SizeOfT = Marshal.SizeOf<IntPtr>();
        }
        else
        {
            SizeOfT = Marshal.SizeOf<T>();
        }

        var address = Marshal.AllocHGlobal(array.Length * SizeOfT);
        Marshal.WriteByte(address, 0, 0);
        for (int itemIndex = 0; itemIndex < array.Length; ++itemIndex)
        {
            T item = array[itemIndex];

            if (item == null)
                continue;

            if (IsNotValueType)
            {
                IntPtr address_item;
                if (typeof(T) == typeof(string))
                {
                    address_item = FromString((string)(object)item);
                }
                else
                {
                    address_item = Marshal.AllocHGlobal(SizeOfT);
                    Marshal.StructureToPtr(item, address, false);
                }


                IntPtr itemAddress = new IntPtr(address_item.ToInt64() + itemIndex * SizeOfT);
                Marshal.StructureToPtr(address_item, itemAddress, false);
            }
            else
            {
                IntPtr itemAddress = new IntPtr(address.ToInt64() + itemIndex * SizeOfT);
                Marshal.StructureToPtr(item, itemAddress, false);
            }
        }
        return address;
    }

    /// <summary>
    /// Converting a Pointer and the Lenght of the array back to Original Array
    /// </summary>
    /// <typeparam name="T">Any Type</typeparam>
    /// <param name="from">The Allocated Pointer to the Array</param>
    /// <param name="arrayLength">The Length of the Array</param>
    /// <returns>The Array</returns>
    public static T[] ToStructArray<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(IntPtr from, int arrayLength)
    {
        var IsNotValueType = !typeof(T).IsValueType;
        int itemSize;
        if (IsNotValueType)
        {
            itemSize = Marshal.SizeOf<IntPtr>();
        }
        else
        {
            itemSize = Marshal.SizeOf<T>();
        }
        List<T> items = new List<T>();
        for (int itemIndex = 0; itemIndex < arrayLength; ++itemIndex)
        {
            IntPtr itemAddress = new IntPtr(from.ToInt64() + itemIndex * itemSize);

            if (IsNotValueType)
            {
                itemAddress = Marshal.ReadIntPtr(itemAddress);
            }

            T item;
            if (typeof(T) == typeof(string))
            {
                string str = ToUTF8String(itemAddress);
                item = (T)(object)(str);
            }
            else
            {
                item = Marshal.PtrToStructure<T>(itemAddress)!;
            }
            items.Add(item);
        }
        return items.ToArray();
    }

    /// <summary>
    /// Destroying the Structure Array
    /// </summary>
    /// <typeparam name="T">The Array Tyep</typeparam>
    /// <param name="from">The Allocated Pointer to the Array</param>
    /// <param name="arrayLength">The Length of the Array</param>
    public static void DestroyStructArray<T>(IntPtr from, int arrayLength)
    {
        var IsNotValueType = !typeof(T).IsValueType;
        int itemSize;
        if (IsNotValueType)
        {
            itemSize = Marshal.SizeOf<IntPtr>();
        }
        else
        {
            itemSize = Marshal.SizeOf<T>();
        }
        for (int itemIndex = 0; itemIndex < arrayLength; ++itemIndex)
        {
            IntPtr itemAddress = new IntPtr(from.ToInt64() + itemIndex * itemSize);

            if (IsNotValueType)
            {
                itemAddress = Marshal.ReadIntPtr(itemAddress);
            }

            if (typeof(T) == typeof(string))
            {
                Marshal.FreeHGlobal(itemAddress);
            }
            else
            {
                Destroy<T>(itemAddress);
            }
        }
    }

    /// <summary>
    /// Destroying the Strucutre and Freeing the Pointer
    /// </summary>
    /// <typeparam name="T">The Type</typeparam>
    /// <param name="itemAddress">The Allocated Address</param>
    public static void Destroy<T>(IntPtr itemAddress)
    {
        Marshal.DestroyStructure<T>(itemAddress);
        Marshal.FreeHGlobal(itemAddress);
    }

    /// <summary>
    /// Making a Structure to a Pointer
    /// </summary>
    /// <typeparam name="T">The Structure Type</typeparam>
    /// <param name="_struct">The Structure Itself</param>
    /// <returns>Allocated Pointer</returns>
    public static IntPtr StructToPtr<T>([DisallowNull] this T _struct)
    {
        var itemSize = Marshal.SizeOf<T>();
        return _struct.StructToPtr(itemSize);
    }

    /// <summary>
    /// Making a Structure to a Pointer with the Size
    /// </summary>
    /// <typeparam name="T">The Structure Type</typeparam>
    /// <param name="_struct">The Structure Itself</param>
    /// <param name="Size">The Structure Size</param>
    /// <returns>Allocated Pointer</returns>
    public static IntPtr StructToPtr<T>([DisallowNull] this T _struct, int Size)
    {
        IntPtr address = Marshal.AllocHGlobal(Size);
        Marshal.StructureToPtr(_struct, address, false);
        return address;
    }

    /// <summary>
    /// Writing the Structure to Output Pointer
    /// </summary>
    /// <typeparam name="T">The Structure Type</typeparam>
    /// <param name="_struct">The Structure Itself</param>
    /// <param name="outPtr">The Pointer to write to</param>
    public static void StructWriteOut<T>([DisallowNull] T _struct, IntPtr outPtr)
    {
        Marshal.WriteIntPtr(outPtr, _struct.StructToPtr());
    }

    /// <summary>
    /// Writing the String into the Output Pointer
    /// </summary>
    /// <param name="str">The String</param>
    /// <param name="outPtr">The Pointer to write to</param>
    public static void StringWriteOut(string str, IntPtr outPtr)
    {
        Marshal.WriteIntPtr(outPtr, str.FromString());
    }

    /// <summary>
    /// Parsing a struct to <see cref="VersionStruct"/> and getting the version from it
    /// </summary>
    /// <param name="struct_ptr">The Structure Itself</param>
    /// <returns>The Structure Version</returns>
    public static int GetVersionFromStructPTR(IntPtr struct_ptr)
    {
        var vers_struct = Marshal.PtrToStructure<VersionStruct>(struct_ptr);
        return vers_struct.version;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct VersionStruct
    {
        public int version;
    }

    /// <summary>
    /// Making a String List to IntPtr
    /// </summary>
    /// <param name="strings">A list of Strings</param>
    /// <returns>The Allocated Pointer</returns>
    public static IntPtr StringListToPtr(this List<string> strings)
    {
        List<IntPtr> ptrs = new();

        foreach (var item in strings)
        {
            ptrs.Add(FromString(item));
        }

        return FromStructArray(ptrs.ToArray());
    }

    /// <summary>
    /// Making a List of Strings from an allocated Pointer and the Length of the String
    /// </summary>
    /// <param name="ptr">The Allocated Pointer</param>
    /// <param name="len">Length of the String</param>
    /// <returns>List of Strings</returns>
    public static List<string> PtrToStringList(IntPtr ptr, int len)
    {
        List<string> strings = new();

        var sarray = ToStructArray<IntPtr>(ptr, len);

        foreach (var item in sarray)
        {
            strings.Add(ToUTF8String(item));
        }

        return strings;
    }

}
