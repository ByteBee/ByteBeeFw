using SwissKnife.Utilities;

namespace SwissKnife.Logging
{
    public class LogLevel : Enum<LogLevel, int>
    {
        public static LogLevel Debug => new LogLevel(1, "debug");
        public static LogLevel Info => new LogLevel(2, "info");
        public static LogLevel Warning => new LogLevel(3, "warn");
        public static LogLevel Error => new LogLevel(4, "error");
        public static LogLevel Critical => new LogLevel(5, "fatal");

        protected LogLevel(int value, string name) : base(value, name)
        {
        }
    }
}
