using System.IO;

namespace SwissKnife.Extensions
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
