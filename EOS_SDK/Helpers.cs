﻿using System.Diagnostics.CodeAnalysis;
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
                    string str = ToString(itemAddress);
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

        public static void Destroy<T>(IntPtr itemAddress)
        {
            Marshal.DestroyStructure<T>(itemAddress);
            Marshal.FreeHGlobal(itemAddress);
        }

        public static IntPtr StructToPtr<T>([DisallowNull] T _struct)
        {
            var itemSize = Marshal.SizeOf<T>();
            IntPtr address = Marshal.AllocHGlobal(itemSize);
            Marshal.StructureToPtr(_struct, address, false);
            return address;
        }


        public static IntPtr StructToPtr<T>([DisallowNull] T _struct, int Size)
        {
            IntPtr address = Marshal.AllocHGlobal(Size);
            Marshal.StructureToPtr(_struct, address, false);
            return address;
        }

        public static void StructWriteOut<T>([DisallowNull] T _struct, IntPtr outPtr)
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

        public static IntPtr StringListToPtr(List<string> strings)
        {
            List<IntPtr> ptrs = new();

            foreach (var item in strings)
            {
                ptrs.Add(FromString(item));
            }

            return FromStructArray(ptrs.ToArray());
        }

        public static List<string> PtrToStringList(IntPtr ptr, int len)
        {
            List<string> strings = new();

            var sarray = ToStructArray<IntPtr>(ptr, len);

            foreach (var item in sarray)
            {
                strings.Add(ToString(item));
            }

            return strings;
        }

    }
}
