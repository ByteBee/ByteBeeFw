using KukSoft.ToolKit.DataTypes;

namespace KukSoft.ToolKit.Enums
{
    public class ComparisonOperator : Enum<ComparisonOperator, int>
    {
        public static ComparisonOperator Equal => new ComparisonOperator(1, (nameof(Equal)));

        public static ComparisonOperator NotEqual => new ComparisonOperator(2, nameof(NotEqual));

        public static ComparisonOperator GreaterThan => new ComparisonOperator(3, nameof(GreaterThan));

        public static ComparisonOperator LessThan => new ComparisonOperator(4, nameof(LessThan));

        protected ComparisonOperator()
        {
        }

        protected ComparisonOperator(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
