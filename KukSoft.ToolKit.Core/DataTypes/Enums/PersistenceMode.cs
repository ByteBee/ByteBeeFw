namespace KukSoft.ToolKit.DataTypes.Enums
{
    public class PersistenceMode : Enum<PersistenceMode, int>
    {
        public static PersistenceMode Live
            => new PersistenceMode(1, nameof(Live));

        public static PersistenceMode Archive
            => new PersistenceMode(2, nameof(Archive));

        public PersistenceMode()
        {
        }

        public PersistenceMode(int value, string displayName)
            : base(value, displayName)
        {
        }
    }
}
