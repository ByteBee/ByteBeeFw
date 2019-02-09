using ByteBee.Utilities;

namespace ByteBee.Security
{
    public interface ICryptoAlgorithm
    {
        Binary Encode(Binary plain);
        Binary Decode(Binary crypted);
    }


    public interface IPrivateKeyAlgorithm : ICryptoAlgorithm
    {

    }

    public interface IPublicKeyAlgorithm : ICryptoAlgorithm
    {

    }

}