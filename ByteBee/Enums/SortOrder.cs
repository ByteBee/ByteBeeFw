using ByteBee.Utilities;

namespace ByteBee.Enums
{
    public class SortOrder : Enum<SortOrder, int>
    {
        public static SortOrder Ascending => new SortOrder(1, nameof(Ascending));
        public static SortOrder Descending => new SortOrder(2, nameof(Descending));

        protected SortOrder()
        {
        }

        protected SortOrder(int value, string name) : base(value, name)
        {
        }
    }
}
