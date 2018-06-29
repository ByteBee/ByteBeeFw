namespace SwissKnife.Logging
{
    public interface ILogFormatter
    {
        string Format(LogMessage message);
    }
}
