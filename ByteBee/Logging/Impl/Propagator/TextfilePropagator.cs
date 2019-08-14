using System.IO;
using ByteBee.Core.Logging.Impl.Formatter;

namespace ByteBee.Core.Logging.Impl.Propagator
{
    public class TextfilePropagator : AbstractLogPropagator
    {
        private readonly ILogFormatter _formatter;
        private readonly string _filename;

        /// <inheritdoc />
        public TextfilePropagator(string filename) : this(filename, new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public TextfilePropagator(string filename, ILogFormatter formatter)
        {
            _formatter = formatter;
            _filename = filename;
        }

        /// <inheritdoc />
        public override void Propagate(LogMessage message)
        {
            File.AppendAllText(_filename, _formatter.Format(message) + "\r\n");
        }
    }
}