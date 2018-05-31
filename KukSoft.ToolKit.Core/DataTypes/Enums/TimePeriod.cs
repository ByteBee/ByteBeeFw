namespace KukSoft.ToolKit.DataTypes.Enums
{
    public class TimePeriod : Enum<PersistenceMode, int>
    {
        public static TimePeriod CurrentDay
            => new TimePeriod(1, "Today");

        public static TimePeriod CurrentMonth
            => new TimePeriod(2, "This Month");

        public static TimePeriod CurrentYear
            => new TimePeriod(3, "This Year");

        public static TimePeriod AllTime
            => new TimePeriod(4, "All Time");

        public TimePeriod()
        {
        }

        public TimePeriod(int value, string displayName)
            : base(value, displayName)
        {
        }
    }
}
