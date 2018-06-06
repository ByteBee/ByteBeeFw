namespace KukSoft.ToolKit.Security
{
    public interface IEncryptionFactory
    {
        IEncryptionEngine MD5 { get; }
        IEncryptionEngine Surprise { get; }
    }
}
