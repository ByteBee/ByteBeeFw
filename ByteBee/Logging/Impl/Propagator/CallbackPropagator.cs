using System;
using ByteBee.Logging.Impl.Formatter;

namespace ByteBee.Logging.Impl.Propagator
{
    public class CallbackPropagator : AbstractLogPropagator
    {
        private readonly ILogFormatter _formatter;
        private readonly Action<string> _callback;

        /// <inheritdoc />
        public CallbackPropagator(Action<string> callback, ILogFormatter formatter)
        {
            _callback = callback;
            _formatter = formatter;
        }

        /// <inheritdoc />
        public CallbackPropagator(Action<string> callback) : this (callback, new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public override void Propagate(LogMessage message)
        {
            _callback(_formatter.Format(message));
        }
    }
}
