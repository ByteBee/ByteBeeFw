namespace KukSoft.ToolKit.Security
{
    class EncryptionFactory : IEncryptionFactory
    {
        public IEncryptionEngine MD5 { get; } = new Md5EncryptionEngine();
        public IEncryptionEngine Surprise { get; } = new MyOwnEncryptionEngine();
    }
}