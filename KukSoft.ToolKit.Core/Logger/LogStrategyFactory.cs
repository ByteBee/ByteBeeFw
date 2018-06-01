using System;
using System.IO;

namespace KukSoft.ToolKit.Logger
{
    class LogStrategyFactory : ILogStrategyFactory
    {
        public LogStrategyFactory() { }

        public ILogStrategy Callback(Action<string> callback)
            => new LogIntoCallback(callback);

        public ILogStrategy Callback(Action<string> callback, ILogFormatter formatter)
            => new LogIntoCallback(callback, formatter);

        public ILogStrategy Composite(ILogStrategy[] strategies)
            => this.Multiple(strategies);

        public ILogStrategy Console()
            => new LogIntoConsole();

        public ILogStrategy Console(ILogFormatter formatter)
            => new LogIntoConsole(formatter);

        public ILogStrategy IfDebug()
            => new LogOnlyForDebug();

        public ILogStrategy IfDebug(ILogFormatter formatter)
            => new LogOnlyForDebug(formatter);

        public ILogStrategy Filter(LogLevel level, ILogStrategy other)
            => new LogLevelFilter(level, other);

        public ILogStrategy Memory()
            => new LogIntoMemory();

        public ILogStrategy Memory(ILogFormatter formatter)
            => new LogIntoMemory(formatter);

        public ILogStrategy Multiple(ILogStrategy[] strategies)
            => new LogIntoMultiple(strategies);

        public ILogStrategy Only(LogLevel level, ILogStrategy other)
            => new LogSingleLevel(level, other);

        public ILogStrategy Single(LogLevel level, ILogStrategy other)
            => new LogSingleLevel(level, other);

        public ILogStrategy Stream(TextWriter stream)
            => new LogIntoStream(stream);

        public ILogStrategy Stream(TextWriter stream, ILogFormatter formatter)
            => new LogIntoStream(stream, formatter);

        public ILogStrategy Textfile(string filename)
            => new LogIntoTextfile(filename);

        public ILogStrategy Textfile(string filename, ILogFormatter formatter)
            => new LogIntoTextfile(filename, formatter);

        public ILogStrategy Without(LogLevel level, ILogStrategy other)
            => new LogWithoutLevel(level, other);
    }
}