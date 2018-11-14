using System.IO;

namespace ByteBee.Logging
{
    public class LogIntoStream : ILogStrategy
    {
        private readonly TextWriter _stream;
        private readonly ILogFormatter _formatter;

        /// <inheritdoc />
        public LogIntoStream(TextWriter stream) : this(stream, new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public LogIntoStream(TextWriter stream, ILogFormatter formatter)
        {
            _stream = stream;
            _formatter = formatter;
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            _stream.WriteLine(_formatter.Format(message));
        }
    }
}