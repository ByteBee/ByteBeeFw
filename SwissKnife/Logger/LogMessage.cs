using System;

namespace SwissKnife.Logger
{
    public struct LogMessage
    {
        public DateTime TimeOfDay { get; }
        public LogLevel LogLevel { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public LogMessage(DateTime timeOfDay, LogLevel logLevel, string message, Exception exception)
        {
            TimeOfDay = timeOfDay;
            LogLevel = logLevel;
            Message = message;
            Exception = exception;
        }

        public LogMessage(LogLevel logLevel, string message, Exception exception)
            : this(DateTime.Now, logLevel, message, exception)
        {
        }
    }
}
