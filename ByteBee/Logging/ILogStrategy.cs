namespace ByteBee.Logging
{
    public interface ILogStrategy
    {
        void Publish(LogMessage message);
    }
}
