using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace Loki
{
    public static class BinaryReaderExtensions
    {
        public static Vector3 ReadVector3(this BinaryReader reader) =>
            new Vector3
            {
                X = reader.ReadSingle(),
                Y = reader.ReadSingle(),
                Z = reader.ReadSingle(),
            };

        public static Vector2i ReadVector2i(this BinaryReader reader) =>
            new Vector2i()
            {
                X = reader.ReadInt32(),
                Y = reader.ReadInt32(),
            };

        public static byte[] ReadByteArray(this BinaryReader reader) => reader.ReadBytes(reader.ReadInt32());

        public static IEnumerable<string> ReadStrings(this BinaryReader reader, int count)
        {
            while (count-- > 0) yield return reader.ReadString();
        }

        public static IEnumerable<int> ReadInt32s(this BinaryReader reader, int count)
        {
            while (count-- > 0) yield return reader.ReadInt32();
        }
    }

    public static class BinaryWriterExtensions
    {
        public static void Write(this BinaryWriter writer, Vector3 vector)
        {
            writer.Write(vector.X);
            writer.Write(vector.Y);
            writer.Write(vector.Z);
        }

        public static void Write(this BinaryWriter writer, Vector2i vector)
        {
            writer.Write(vector.X);
            writer.Write(vector.Y);
        }

        public static void WriteCountItems(this BinaryWriter writer, IList<string> items)
        {
            writer.Write(items.Count);
            foreach (string item in items) 
                writer.Write(item);
        }

        public static void WriteCountItems(this BinaryWriter writer, IList<int> items)
        {
            writer.Write(items.Count);
            foreach (int item in items)
                writer.Write(item);
        }

        public static void WriteByteArray(this BinaryWriter writer, byte[] data)
        {
            writer.Write(data.Length);
            writer.Write(data);
        }
    }

    public static class Shell32
    {
        public static Guid LocalLowId = new Guid("A520A1A4-1780-4FF6-BD18-167343C5AF16");

        public static string GetKnownFolderPath(Guid knownFolderId)
        {
            IntPtr pszPath = IntPtr.Zero;
            try
            {
                int hr = SHGetKnownFolderPath(knownFolderId, 0, IntPtr.Zero, out pszPath);
                if (hr >= 0)
                    return Marshal.PtrToStringAuto(pszPath);
                Exception ex = Marshal.GetExceptionForHR(hr);
                throw ex ?? new Win32Exception(hr, "Unknown error");
            }
            finally
            {
                if (pszPath != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(pszPath);
            }
        }

        [DllImport("shell32.dll")]
        private static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);
    }
}
