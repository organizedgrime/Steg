using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;

namespace Steg
{

    public static class MIMEAssistant
    {
        [DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
        private extern static UInt32 FindMimeFromData(
            UInt32 pBC,
            [MarshalAs(UnmanagedType.LPStr)] String pwzUrl,
            [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
            UInt32 cbSize,
            [MarshalAs(UnmanagedType.LPStr)] String pwzMimeProposed,
            UInt32 dwMimeFlags,
            out UInt32 ppwzMimeOut,
            UInt32 dwReserverd
        );

        public static string GetMIMEType(byte[] bytes)
        {
            byte[] buffer = new byte[256];
            MemoryStream ms = new MemoryStream(bytes);
            if (ms.Length >= 256)
                ms.Read(buffer, 0, 256);
            else
                ms.Read(buffer, 0, (int)ms.Length);
            try
            {
                UInt32 mimetype;
                FindMimeFromData(0, null, buffer, 256, null, 0, out mimetype, 0);
                IntPtr mimeTypePtr = new IntPtr(mimetype);
                string mime = Marshal.PtrToStringUni(mimeTypePtr);
                Marshal.FreeCoTaskMem(mimeTypePtr);
                return mime;
            }
            catch (Exception e)
            {
                return "unknown/unknown";
            }
        }

        public static string GetDefaultExtension(string mimeType)
        {
            string result;
            Microsoft.Win32.RegistryKey key;
            object value;

            key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + mimeType, false);
            value = key != null ? key.GetValue("Extension", null) : null;
            result = value != null ? value.ToString() : string.Empty;

            return result;
        }

        public static byte[] VerifyJPEG(byte[] outputData)
        {
            // Make an int to keep track of how many stages have been passed.
            // Once all 11 have been passed, the JPEG is VALID.
            int i = 1, key = 0;
            int[] keywords = new int[10] {0xD8, 0xD0, 0xD1, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6, 0xD7, 0xD9};
            while (i < outputData.Length)
            {
                // Check if the current 2 bytes are a marker
                if (outputData[i - 1] == 0xFF && outputData[i] == keywords[key])
                {
                    if(key == 9)
                    {
                        return outputData.ToList().Take(i).ToArray();
                    }
                    int add = (outputData[i + 1] << 8) + outputData[i + 2] - 2;
                    //MessageBox.Show("i: " + i + ", (i + 1): " + outputData[i+1] + ", (i + 2): " + outputData[i+2] + ", add: " + add);
                    i += add;
                    key++;
                }
                else
                {
                    i++;
                }
            }
            return outputData;
        }
    }
}
