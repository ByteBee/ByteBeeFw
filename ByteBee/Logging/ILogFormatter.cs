namespace ByteBee.Logging
{
    public interface ILogFormatter
    {
        string Format(LogMessage message);
    }
}
