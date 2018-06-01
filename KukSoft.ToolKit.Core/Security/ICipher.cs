using System.IO;

namespace KukSoft.ToolKit.Security
{
    public interface ICipher
    {
        string Encode(string plain, string privateKey);
        string Encode(byte[] plain, string privateKey);
        string Encode(Stream stream, string privateKey);
        string Encode(FileInfo file, string privateKey);

        string Decode(string crypted, string privateKey);

        string Encode(string plain);
        string Encode(byte[] plain);
        string Encode(Stream stream);
        string Encode(FileInfo file);

        string Decode(string crypted);
    }
}
