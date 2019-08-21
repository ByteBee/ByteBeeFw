using ByteBee.Enums;

namespace ByteBee.Logging.Impl.Propagator
{
    public abstract class AbstractLogPropagator : ILogPropagator
    {
        private ILogFilter _filter;
        /// <inheritdoc />
        public ILogPropagator FilterWith(ILogFilter filter)
        {
            filter.Next = _filter;
            _filter = filter;

            return this;
        }

        protected bool IsQuietDown(LogMessage message)
        {
            BinaryAnswer answer = _filter.Ask(message);

            return answer == BinaryAnswer.Nope;

        }

        public abstract void Propagate(LogMessage message);
    }
}