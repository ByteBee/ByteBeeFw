namespace ByteBee.Core.Security.Cryptography
{
    public interface IHashAlgorithm
    {
        byte[] Compute(byte[] plain);
    }
}