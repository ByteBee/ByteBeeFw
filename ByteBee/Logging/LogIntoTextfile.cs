using System.IO;

namespace ByteBee.Logging
{
    public class LogIntoTextfile : ILogStrategy
    {
        private readonly ILogFormatter _formatter;
        private readonly string _filename;

        /// <inheritdoc />
        public LogIntoTextfile(string filename) : this(filename, new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public LogIntoTextfile(string filename, ILogFormatter formatter)
        {
            _formatter = formatter;
            _filename = filename;
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            File.AppendAllText(_filename, _formatter.Format(message) + "\r\n");
        }
    }
}