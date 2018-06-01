namespace KukSoft.ToolKit.Security
{
    class CipherFactory : ICipherFactory
    {
        public ICipher MD5 { get; } = new Md5Cipher();
    }
}
