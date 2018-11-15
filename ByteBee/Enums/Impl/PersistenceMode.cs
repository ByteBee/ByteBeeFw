namespace ByteBee.Enums.Impl
{
    public class PersistenceMode : TypedEnum<PersistenceMode, int>
    {
        public static PersistenceMode Live => new PersistenceMode(1, nameof(Live));
        public static PersistenceMode Archive => new PersistenceMode(2, nameof(Archive));
        
        protected PersistenceMode(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
