using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KukSoft.ToolKit.Extension
{
    public static class StreamExt
    {
        public static byte[] ToByteArray(this Stream self)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                self.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
