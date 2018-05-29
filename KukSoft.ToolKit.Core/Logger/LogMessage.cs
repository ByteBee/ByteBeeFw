using System;

namespace KukSoft.ToolKit.Logger
{
    public struct LogMessage
    {
        public DateTime TimeOfDay { get; set; }
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
