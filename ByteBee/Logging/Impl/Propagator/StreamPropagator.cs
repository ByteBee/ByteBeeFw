using System.IO;
using ByteBee.Core.Logging.Impl.Formatter;

namespace ByteBee.Core.Logging.Impl.Propagator
{
    public class StreamPropagator : AbstractLogPropagator
    {
        private readonly TextWriter _stream;
        private readonly ILogFormatter _formatter;

        /// <inheritdoc />
        public StreamPropagator(TextWriter stream) : this(stream, new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public StreamPropagator(TextWriter stream, ILogFormatter formatter)
        {
            _stream = stream;
            _formatter = formatter;
        }

        /// <inheritdoc />
        public override void Propagate(LogMessage message)
        {
            _stream.WriteLine(_formatter.Format(message));
        }
    }
}