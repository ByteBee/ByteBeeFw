using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Core.Enums
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public class SortOrder : BeeEnum<SortOrder, int>
    {
        public static SortOrder Ascending { get; } = new SortOrder(1, nameof(Ascending));
        public static SortOrder Descending { get; } = new SortOrder(2, nameof(Descending));

        protected SortOrder(int value, string name) : base(value, name)
        {
        }
    }
}
