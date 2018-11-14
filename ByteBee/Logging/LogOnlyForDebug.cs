namespace ByteBee.Logging
{
    public class LogOnlyForDebug : ILogStrategy
    {
        private readonly ILogFormatter _loggerFormatter;

        /// <inheritdoc />
        public LogOnlyForDebug() : this(new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public LogOnlyForDebug(ILogFormatter loggerFormatter)
        {
            _loggerFormatter = loggerFormatter;
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            System.Diagnostics.Debug.WriteLine(_loggerFormatter.Format(message));
        }
    }
}
