using ByteBee.Core.Enums;

namespace ByteBee.Core.Logging.Impl.Filter
{
    public class LogLevelRangeFilter : ILogFilter
    {
        private readonly LogLevel _from;
        private readonly LogLevel _until;

        public LogLevelRangeFilter(LogLevel @from, LogLevel until)
        {
            _from = @from;
            _until = until;
        }
        
        public BinaryAnswer Ask(LogMessage message)
        {
            if (message.LogLevel < _from)
                return BinaryAnswer.Nope;

            if (message.LogLevel > _until) 
                return BinaryAnswer.Nope;

            return Next?.Ask(message);
        }

        public ILogFilter Next { get; set; }
    }
}
