using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

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
            bool skip = false;
            for (int i = 1; i < outputData.Length; i++)
            {
                if (outputData[i - 1] == 0xFF)
                {
                    switch (outputData[i])
                    {

                        case 0xD8:
                            skip = true;
                            break;

                        case 0x01:
                            skip = true;
                            break;

                        case 0xD0:
                            skip = true;
                            break;

                        case 0xD1:
                            skip = true;
                            break;

                        case 0xD2:
                            skip = true;
                            break;

                        case 0xD3:
                            skip = true;
                            break;

                        case 0xD4:
                            skip = true;
                            break;

                        case 0xD5:
                            skip = true;
                            break;

                        case 0xD6:
                            skip = true;
                            break;

                        case 0xD7:
                            skip = true;
                            break;

                        case 0xD9:
                            return outputData.ToList().Take(i).ToArray();

                        default:
                            break;

                    }
                    if (skip)
                    {
                        int add = BitConverter.ToInt16(outputData, i) - 2;
                        MessageBox.Show("i: " + i + ", add: " + outputData[i + 2] + ":" + outputData[i + 1]);
                        //i -= add;
                        skip = false;
                    }
                }

            }
            return outputData;
        }
    }
}
