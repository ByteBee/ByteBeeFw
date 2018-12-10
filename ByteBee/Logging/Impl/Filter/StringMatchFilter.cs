using System.Text.RegularExpressions;
using ByteBee.Enums.Impl;

namespace ByteBee.Logging.Impl.Filter
{
    public class StringMatchFilter : ILogFilter
    {
        private readonly Regex _regex;

        /// <inheritdoc />
        public StringMatchFilter(string regexPattern) 
            => _regex = new Regex(regexPattern);

        /// <inheritdoc />
        public StringMatchFilter(Regex regex)
        {
            _regex = regex;
        }

        /// <inheritdoc />
        public BinaryAnswer Ask(LogMessage message)
        {
            if (!_regex.Match(message.Message).Success)
                return BinaryAnswer.Nope;

            return Next?.Ask(message);
        }

        /// <inheritdoc />
        public ILogFilter Next { get; set; }
    }
}
