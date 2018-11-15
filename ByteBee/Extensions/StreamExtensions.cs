using System.IO;

namespace ByteBee.Extensions
{
    public static class StreamExtensions
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
