namespace SwissKnife.Security
{
    public interface IEncryptionFactory
    {
        IEncryptionEngine MD5 { get; }
        IEncryptionEngine Surprise { get; }
    }
}
