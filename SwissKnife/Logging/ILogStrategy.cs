namespace SwissKnife.Logging
{
    public interface ILogStrategy
    {
        void Publish(LogMessage message);
    }
}
