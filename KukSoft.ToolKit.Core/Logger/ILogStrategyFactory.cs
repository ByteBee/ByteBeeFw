using System;
using System.IO;

namespace KukSoft.ToolKit.Logger
{
    public interface ILogStrategyFactory
    {
        ILogStrategy Callback(Action<string> callback);
        ILogStrategy Callback(Action<string> callback, ILogFormatter formatter);

        ILogStrategy Console();
        ILogStrategy Console(ILogFormatter formatter);

        ILogStrategy Memory();
        ILogStrategy Memory(ILogFormatter formatter);

        ILogStrategy Stream(TextWriter stream);
        ILogStrategy Stream(TextWriter stream, ILogFormatter formatter);

        ILogStrategy Textfile(string filename);
        ILogStrategy Textfile(string filename, ILogFormatter formatter);

        ILogStrategy Multiple(ILogStrategy[] strategies);
        ILogStrategy Composite(ILogStrategy[] strategies);

        ILogStrategy Filter(LogLevel level, ILogStrategy other);
        ILogStrategy Single(LogLevel level, ILogStrategy other);
        ILogStrategy Only(LogLevel level, ILogStrategy other);
        ILogStrategy Without(LogLevel level, ILogStrategy other);
    }
}