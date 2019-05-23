using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Enums.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public class TimePeriod : BeeEnum<PersistenceMode, int>
    {
        public static TimePeriod CurrentDay { get; } = new TimePeriod(1, "Today");
        public static TimePeriod CurrentMonth { get; } = new TimePeriod(2, "This Month");
        public static TimePeriod CurrentYear { get; } = new TimePeriod(3, "This Year");
        public static TimePeriod AllTime { get; } = new TimePeriod(4, "All Time");

        protected TimePeriod(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
