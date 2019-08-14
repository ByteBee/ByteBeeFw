using ByteBee.Core.Enums;

namespace ByteBee.Core.Logging.Impl.Filter
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