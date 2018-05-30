using System.IO;

namespace KukSoft.ToolKit.Logger
{
    class LogIntoStream : ILogStrategy
    {
        private readonly TextWriter _stream;
        private readonly ILogFormatter _formatter;

        public LogIntoStream(TextWriter stream) : this(stream, new StandardLogFormatter())
        {
        }

        public LogIntoStream(TextWriter stream, ILogFormatter formatter)
        {
            _stream = stream;
            _formatter = formatter;
        }

        public void Publish(LogMessage message)
        {
            _stream.WriteLine(_formatter.Format(message));
        }
    }
}