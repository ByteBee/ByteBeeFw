using System;

namespace ByteBee.Logging
{
    public class LogIntoCallback : ILogStrategy
    {
        private readonly ILogFormatter _formatter;
        private readonly Action<string> _callback;

        /// <inheritdoc />
        public LogIntoCallback(Action<string> callback, ILogFormatter formatter)
        {
            _callback = callback;
            _formatter = formatter;
        }

        /// <inheritdoc />
        public LogIntoCallback(Action<string> callback) : this (callback, new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            _callback(_formatter.Format(message));
        }
    }
}
