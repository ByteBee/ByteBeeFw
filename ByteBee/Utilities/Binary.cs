using System.IO;
using System.Text;

namespace ByteBee.Utilities
{
    public sealed class Binary
    {
        private readonly byte[] _data;

        public Binary(byte[] data) => _data = data;

        public Binary(string data) : this(data, Encoding.Default) { }

        public Binary(string data, Encoding encoding)
        {
            _data = string.IsNullOrWhiteSpace(data)
                ? new byte[0]
                : encoding.GetBytes(data);
        }

        public Binary(Stream data)
        {
            using (var ms = new MemoryStream())
            {
                data.CopyTo(ms);
                _data = ms.GetBuffer();
            }
        }

        public override string ToString() => Encoding.Default.GetString(_data);
        public string ToString(Encoding encoding) => encoding.GetString(_data);
        public byte[] ToBytes() => _data;
        private Stream ToStream() => new MemoryStream(_data);

        public static implicit operator Binary(string str) => new Binary(str);
        public static implicit operator Binary(Stream stream) => new Binary(stream);
        public static implicit operator Binary(byte[] data) => new Binary(data);

        public static implicit operator string(Binary data) => data.ToString();
        public static implicit operator byte[](Binary data) => data.ToBytes();
        public static implicit operator Stream(Binary data) => data.ToStream();


    }
}