using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography
{
    public interface IHashFactory
    {
        Binary Compute(Binary plain);
        Binary ComputeWithSalt(Binary plain);
        Binary ComputeWithSalt(Binary plain, string salt);
        Binary ComputeWithSaltAndPepper(Binary plain);
        Binary ComputeWithSaltAndPepper(Binary plain, string salt);
        Binary ComputeWithSaltAndPepper(Binary plain, string salt, string pepper);
    }
}