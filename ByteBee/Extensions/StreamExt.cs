using System.IO;

namespace ByteBee.Extensions
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
