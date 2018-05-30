using System;
using System.Collections.Concurrent;

namespace KukSoft.ToolKit.Logger
{
    class StandardLogger : ILogger
    {
        private readonly ConcurrentBag<ILogStrategy> _logStrategies;

        private bool _isTurnedOff = false;

        public LogLevel DefaultLogLevel { get; set; } = LogLevel.Info;

        public StandardLogger(ILogStrategy[] strategies)
        {
            _logStrategies = new ConcurrentBag<ILogStrategy>(strategies);
        }

        public void Register(ILogStrategy strategy)
            => _logStrategies.Add(strategy);

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

        public void Log(string message)
            => Log(DefaultLogLevel, message);

        public void Log(string message, Exception ex)
            => Error(message, ex);

        public void Log(LogLevel level, string message)
            => Log(level, message, null);

        public void Log(Exception ex)
            => Critical(ex.Message, ex);

        public void Log(LogLevel level, string message, Exception ex)
            => Log(new LogMessage(level, message, ex));
               
        public void TurnOff()
            => _isTurnedOff = true;

        public void TurnOn()
            => _isTurnedOff = false;

        public void Debug(string message)
            => Log(LogLevel.Debug, message);

        public void Info(string message)
            => Log(LogLevel.Info, message);

        public void Warning(string message)
            => Log(LogLevel.Warning, message);

        public void Warning(string message, Exception ex)
            => Log(LogLevel.Warning, message, ex);

        public void Error(string message)
            => Log(LogLevel.Error, message);

        public void Error(string message, Exception ex)
            => Log(LogLevel.Error, message, ex);

        public void Critical(string message)
            => Log(LogLevel.Critical, message);

        public void Critical(string message, Exception ex)
            => Log(LogLevel.Critical, message, ex);

    }
}