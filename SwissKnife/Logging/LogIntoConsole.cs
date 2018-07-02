using System;

namespace SwissKnife.Logging
{
    public class LogIntoConsole : LogIntoStream
    {
        /// <inheritdoc />
        public LogIntoConsole(ILogFormatter formatter) : base(Console.Out, formatter)
        {
        }

        /// <inheritdoc />
        public LogIntoConsole() : base(Console.Out, new StandardLogFormatter())
        {
        }
    }
}