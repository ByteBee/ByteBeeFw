using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography
{
    public interface IHashAlgorithm
    {
        byte[] Compute(byte[] plain);
    }
}