using KukSoft.ToolKit.DataTypes;

namespace KukSoft.ToolKit.Enums
{
    public class PersistenceMode : Enum<PersistenceMode, int>
    {
        public static PersistenceMode Live => new PersistenceMode(1, nameof(Live));
        public static PersistenceMode Archive => new PersistenceMode(2, nameof(Archive));

        protected PersistenceMode()
        {
        }

        protected PersistenceMode(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
