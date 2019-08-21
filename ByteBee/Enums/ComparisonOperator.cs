using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Enums
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public class ComparisonOperator : BeeEnum<ComparisonOperator, int>
    {
        public static ComparisonOperator Equal { get; } = new ComparisonOperator(1, (nameof(Equal)));

        public static ComparisonOperator NotEqual { get; } = new ComparisonOperator(2, nameof(NotEqual));

        public static ComparisonOperator GreaterThan { get; } = new ComparisonOperator(3, nameof(GreaterThan));

        public static ComparisonOperator LessThan { get; } = new ComparisonOperator(4, nameof(LessThan));

        protected ComparisonOperator(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
