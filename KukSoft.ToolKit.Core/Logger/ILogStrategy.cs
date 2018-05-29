namespace KukSoft.ToolKit.Logger
{
    public interface ILogStrategy
    {
        void Publish(LogMessage message);
    }
}
