using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace EOS_SDK
{
    public class Helpers
    {
        public static IntPtr FromString(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var result_bytes = bytes.Concat(new byte[] { 0x00 }).ToArray();
            var PTR = Marshal.AllocHGlobal(bytes.Length + 1);
            Marshal.Copy(result_bytes, 0, PTR, result_bytes.Length);
            return PTR;
        }

        public static string ToString(IntPtr source)
        {
            if (source == IntPtr.Zero)
            {
                return string.Empty;
            }

            // C style strlen
            int length = GetAnsiStringLength(source);

            // +1 byte for the null terminator.
            byte[] bytes = new byte[length + 1];
            Marshal.Copy(source, bytes, 0, length + 1);
            return Encoding.UTF8.GetString(bytes);
        }
        public static int GetAnsiStringLength(IntPtr address)
        {
            int length = 0;
            while (Marshal.ReadByte(address, length) != 0)
            {
                ++length;
            }

            return length;
        }

        public static IntPtr FromStructArray<T>(T[] array)
        {
            var IsNotValueType = !typeof(T).IsValueType;
            int SizeOfT;
            if (IsNotValueType)
            {
                SizeOfT = Marshal.SizeOf(typeof(IntPtr));
            }
            else
            {
                SizeOfT = Marshal.SizeOf(typeof(T));
            }

            var address = Marshal.AllocHGlobal(array.Length * SizeOfT);
            Marshal.WriteByte(address, 0, 0);
            for (int itemIndex = 0; itemIndex < array.Length; ++itemIndex)
            {
                T item = array[itemIndex];
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

        public static T[] ToStructArray<T>(IntPtr from, int arrayLength)
        {
            var IsNotValueType = !typeof(T).IsValueType;
            int itemSize;
            if (IsNotValueType)
            {
                itemSize = Marshal.SizeOf(typeof(IntPtr));
            }
            else
            {
                itemSize = Marshal.SizeOf(typeof(T));
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
                    string str = ToString(itemAddress);
                    item = (T)(object)(str);
                }
                else
                {
                    item = (T)Marshal.PtrToStructure(itemAddress, typeof(T));
                }
                items.Add(item);
            }
            return items.ToArray();
        }

        public static void DestroyStructArray<T>(IntPtr from, int arrayLength)
        {
            var IsNotValueType = !typeof(T).IsValueType;
            int itemSize;
            if (IsNotValueType)
            {
                itemSize = Marshal.SizeOf(typeof(IntPtr));
            }
            else
            {
                itemSize = Marshal.SizeOf(typeof(T));
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

        public static void Destroy<T>(IntPtr itemAddress)
        {
            Marshal.DestroyStructure<T>(itemAddress);
            Marshal.FreeHGlobal(itemAddress);
        }

        public static IntPtr StructToPtr<T>(T _struct)
        {
            var itemSize = Marshal.SizeOf(typeof(T));
            IntPtr address = Marshal.AllocHGlobal(itemSize);
            Marshal.StructureToPtr(_struct, address, false);
            return address;
        }

        public static IntPtr StructToPtr(object _struct, Type type)
        {
            var itemSize = Marshal.SizeOf(type);
            IntPtr address = Marshal.AllocHGlobal(itemSize);
            Marshal.StructureToPtr(_struct, address, false);
            return address;
        }

        public static void StructWriteOut<T>(T _struct, IntPtr outPtr)
        {
            var ptr = StructToPtr(_struct);
            Marshal.WriteIntPtr(outPtr, ptr);
        }

        public static void StringWriteOut(string str, IntPtr outPtr)
        {
            Marshal.WriteIntPtr(outPtr, FromString(str));
        }

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
    }
}
