namespace ByteBee.Enums.Impl
{
    public class SortOrder : TypedEnum<SortOrder, int>
    {
        public static SortOrder Ascending => new SortOrder(1, nameof(Ascending));
        public static SortOrder Descending => new SortOrder(2, nameof(Descending));

        protected SortOrder(int value, string name) : base(value, name)
        {
        }
    }
}
