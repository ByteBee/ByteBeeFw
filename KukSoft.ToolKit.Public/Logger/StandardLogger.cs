using System;

namespace KukSoft.ToolKit.Logger.Public
{
    public class StandardLogger : ILogger
    {
        private readonly ILogger _logger;

        public StandardLogger(ILogStrategy[] strategies) 
            => _logger = new Logger.StandardLogger(strategies);

        public void Critical(string message) => _logger.Critical(message);
        public void Critical(string message, Exception ex) => _logger.Critical(message, ex);
        public void Debug(string message) => _logger.Debug(message);
        public void Error(string message) => _logger.Error(message);
        public void Error(string message, Exception ex) => _logger.Error(message, ex);
        public void Info(string message) => _logger.Info(message);
        public void Log(string message) => _logger.Log(message);
        public void Log(string message, Exception ex) => _logger.Log(message, ex);
        public void Log(Exception ex) => _logger.Log(ex);
        public void Log(LogLevel level, string message) => _logger.Log(level, message);
        public void Log(LogLevel level, string message, Exception ex) => _logger.Log(level, message, ex);
        public void Log(LogMessage message) => _logger.Log(message);
        public void Register(ILogStrategy loggerHandler) => _logger.Register(loggerHandler);
        public void TurnOff() => _logger.TurnOff();
        public void TurnOn() => _logger.TurnOn();
        public void Warning(string message) => _logger.Warning(message);
        public void Warning(string message, Exception ex) => _logger.Warning(message, ex);
    }
}