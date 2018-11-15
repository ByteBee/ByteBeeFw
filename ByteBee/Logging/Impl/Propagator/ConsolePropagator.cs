using System;
using ByteBee.Logging.Impl.Formatter;

namespace ByteBee.Logging.Impl.Propagator
{
    public class ConsolePropagator : StreamPropagator
    {
        /// <inheritdoc />
        public ConsolePropagator(ILogFormatter formatter) : base(Console.Out, formatter)
        {
        }

        /// <inheritdoc />
        public ConsolePropagator() : base(Console.Out, new StandardLogFormatter())
        {
        }
    }
}