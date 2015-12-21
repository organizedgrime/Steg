using System;
using System.Runtime.InteropServices;
using System.IO;

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
    }
}
