using System.Collections.Concurrent;

namespace SwissKnife.Logging
{
    public class LogIntoMultiple : ILogStrategy
    {
        private readonly ConcurrentBag<ILogStrategy> _strategies;

        public LogIntoMultiple(ILogStrategy[] strategies)
        {
            _strategies = new ConcurrentBag<ILogStrategy>(strategies);
        }

        public void Publish(LogMessage message)
        {
            foreach (ILogStrategy log in _strategies)
            {
                log.Publish(message);
            }
        }
    }
}
