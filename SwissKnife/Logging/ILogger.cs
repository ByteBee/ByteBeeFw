using System;

namespace SwissKnife.Logging
{
    public interface ILogger
    {
        void Register(ILogStrategy loggerHandler);

        void Log(string message);
        void Log(string message, Exception ex);
        void Log(Exception ex);
        void Log(LogLevel level, string message);
        void Log(LogLevel level, string message, Exception ex);
        void Log(LogMessage message);

        void Debug(string message);
        void Info(string message);

        void Warning(string message);
        void Warning(string message, Exception ex);

        void Error(string message);
        void Error(string message, Exception ex);

        void Critical(string message);
        void Critical(string message, Exception ex);

        void TurnOff();
        void TurnOn();
    }
}
