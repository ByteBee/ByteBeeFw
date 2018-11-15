using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBee.Logging.Impl.Formatter
{
    public class StandardLogFormatter : ILogFormatter
    {
        /// <inheritdoc />
        public string Format(LogMessage message)
        {
            string preamble = $"[{message.TimeOfDay} $ {message.LogLevel.Value}] ";
            string content = preamble;
            content += message.Message;

            if (message.Exception != null)
            {
                content += "\r\n";
                content += FormatException(preamble, message.Exception);
            }

            return content;
        }

        private string FormatException(string preamble, Exception ex)
        {
            string text =  string.Empty;

            if (ex != null)
            {
                var lines = new List<string>();
                lines.Add($"{ex.GetType().FullName}: {ex.Message}\r");
                lines.AddRange(ex.StackTrace.Split('\n'));

                text = FormatException(preamble, ex.InnerException);
                text = lines.Aggregate(text, (c, line) => c += preamble + "~> " + line + "\n");
            }

            return text;
        }
    }
}
