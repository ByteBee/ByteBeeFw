namespace SwissKnife.Logger
{
    public interface ILogFormatter
    {
        string Format(LogMessage message);
    }
}
