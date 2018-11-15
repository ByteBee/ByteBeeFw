using ByteBee.Enums.Impl;

namespace ByteBee.Logging.Impl.Filter
{
    public class AllowAllFilter : ILogFilter
    {
        /// <inheritdoc />
        public BinaryAnswer Ask(LogMessage message)
        {
            return BinaryAnswer.Yep;
        }

        /// <inheritdoc />
        public ILogFilter Next { get; set; }
    }
}