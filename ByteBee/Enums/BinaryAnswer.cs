using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Core.Enums
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class BinaryAnswer : BeeEnum<BinaryAnswer, int>
    {
        public static BinaryAnswer Nope { get; } = new BinaryAnswer(-1, "no");
        public static BinaryAnswer Maybe { get; } = new BinaryAnswer(0, "maybe");
        public static BinaryAnswer Yep { get; } = new BinaryAnswer(1, "yes");

        private BinaryAnswer(int value, string name) : base(value, name)
        {
        }
    }
}