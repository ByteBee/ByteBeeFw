using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Enums.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public class LogLevel : BeeEnum<LogLevel, int>
    {
        public static LogLevel Verbose { get; } = new LogLevel(0, "verbose");
        public static LogLevel Debug { get; } = new LogLevel(1, "debug");
        public static LogLevel Info { get; } = new LogLevel(2, "info");
        public static LogLevel Warning { get; } = new LogLevel(3, "warn");
        public static LogLevel Error { get; } = new LogLevel(4, "error");
        public static LogLevel Critical { get; } = new LogLevel(5, "fatal");

        protected LogLevel(int value, string name) : base(value, name)
        {
        }
    }
}