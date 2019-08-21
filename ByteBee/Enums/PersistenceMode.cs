using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Enums
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public class PersistenceMode : BeeEnum<PersistenceMode, int>
    {
        public static PersistenceMode Live { get; } = new PersistenceMode(1, nameof(Live));
        public static PersistenceMode Archive { get; } = new PersistenceMode(2, nameof(Archive));
        
        protected PersistenceMode(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
