namespace SwissKnife.Logger
{
    public interface ILogStrategy
    {
        void Publish(LogMessage message);
    }
}
