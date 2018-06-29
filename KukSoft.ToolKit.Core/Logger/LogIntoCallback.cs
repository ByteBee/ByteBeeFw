using System;

namespace KukSoft.ToolKit.Logger
{
    public class LogIntoCallback : ILogStrategy
    {
        private readonly ILogFormatter _formatter;
        private readonly Action<string> _callback;

        public LogIntoCallback(Action<string> callback, ILogFormatter formatter)
        {
            _callback = callback;
            _formatter = formatter;
        }

        public LogIntoCallback(Action<string> callback) : this (callback, new StandardLogFormatter())
        {
        }

        public void Publish(LogMessage message)
        {
            _callback(_formatter.Format(message));
        }
    }
}
