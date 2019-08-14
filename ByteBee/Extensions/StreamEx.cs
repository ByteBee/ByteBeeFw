using System.IO;

namespace ByteBee.Core.Extensions
{
    public static class StreamEx
    {
        public static byte[] ToByteArray(this Stream self)
        {
            using (var ms = new MemoryStream())
            {
                self.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
