namespace ByteBee.Core.Logging
{
    public interface ILogFormatter
    {
        string Format(LogMessage message);
    }
}
