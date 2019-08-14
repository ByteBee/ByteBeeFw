using ByteBee.Core.Logging.Impl.Formatter;

namespace ByteBee.Core.Logging.Impl.Propagator
{
    public class DebugPropagator : AbstractLogPropagator
    {
        private readonly ILogFormatter _loggerFormatter;

        /// <inheritdoc />
        public DebugPropagator() : this(new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public DebugPropagator(ILogFormatter loggerFormatter)
        {
            _loggerFormatter = loggerFormatter;
        }

        /// <inheritdoc />
        public override void Propagate(LogMessage message)
        {
            System.Diagnostics.Debug.WriteLine(_loggerFormatter.Format(message));
        }
    }
}
