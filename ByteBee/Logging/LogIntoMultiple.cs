using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ByteBee.Logging
{
    public class LogIntoMultiple : ILogStrategy
    {
        private readonly ConcurrentBag<ILogStrategy> _strategies;

        /// <inheritdoc />
        public LogIntoMultiple(IEnumerable<ILogStrategy> strategies)
        {
            _strategies = new ConcurrentBag<ILogStrategy>(strategies);
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            foreach (ILogStrategy log in _strategies)
            {
                log.Publish(message);
            }
        }
    }
}
