using System;
using System.Collections.Concurrent;

namespace SwissKnife.Logging
{
    public class StandardLogger : ILogger
    {
        private readonly ConcurrentBag<ILogStrategy> _logStrategies;

        private bool _isTurnedOff;

        /// <inheritdoc />
        public LogLevel DefaultLogLevel { get; set; } = LogLevel.Info;

        /// <inheritdoc />
        public StandardLogger()
            => _logStrategies = new ConcurrentBag<ILogStrategy>();

        /// <inheritdoc />
        public StandardLogger(ILogStrategy[] strategies)
            => _logStrategies = new ConcurrentBag<ILogStrategy>(strategies);

        /// <inheritdoc />
        public void Register(ILogStrategy strategy)
            => _logStrategies.Add(strategy);

        /// <inheritdoc />
        public void Log(LogMessage message)
        {
            if (!_isTurnedOff)
            {
                foreach (ILogStrategy log in _logStrategies)
                {
                    log.Publish(message);
                }
            }
        }

        /// <inheritdoc />
        public void Log(string message) => Log(DefaultLogLevel, message);
        /// <inheritdoc />
        public void Log(string message, Exception ex) => Error(message, ex);
        /// <inheritdoc />
        public void Log(LogLevel level, string message) => Log(level, message, null);
        /// <inheritdoc />
        public void Log(Exception ex) => Critical(ex.Message, ex);
        /// <inheritdoc />
        public void Log(LogLevel level, string message, Exception ex) => Log(new LogMessage(level, message, ex));
        /// <inheritdoc />
        public void TurnOff() => _isTurnedOff = true;
        /// <inheritdoc />
        public void TurnOn() => _isTurnedOff = false;
        /// <inheritdoc />
        public void Debug(string message) => Log(LogLevel.Debug, message);
        /// <inheritdoc />
        public void Info(string message) => Log(LogLevel.Info, message);
        /// <inheritdoc />
        public void Warning(string message) => Log(LogLevel.Warning, message);
        /// <inheritdoc />
        public void Warning(string message, Exception ex) => Log(LogLevel.Warning, message, ex);
        /// <inheritdoc />
        public void Error(string message) => Log(LogLevel.Error, message);
        /// <inheritdoc />
        public void Error(string message, Exception ex) => Log(LogLevel.Error, message, ex);
        /// <inheritdoc />
        public void Critical(string message) => Log(LogLevel.Critical, message);
        /// <inheritdoc />
        public void Critical(string message, Exception ex) => Log(LogLevel.Critical, message, ex);
    }
}