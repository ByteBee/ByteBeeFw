using KukSoft.ToolKit.DataTypes;

namespace KukSoft.ToolKit.Enums
{
    public class TimePeriod : Enum<PersistenceMode, int>
    {
        public static TimePeriod CurrentDay => new TimePeriod(1, "Today");
        public static TimePeriod CurrentMonth => new TimePeriod(2, "This Month");
        public static TimePeriod CurrentYear => new TimePeriod(3, "This Year");
        public static TimePeriod AllTime => new TimePeriod(4, "All Time");

        protected TimePeriod()
        {
        }

        protected TimePeriod(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
