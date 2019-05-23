using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Enums.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public class BinaryAnswer : BeeEnum<BinaryAnswer, int>
    {

        public static BinaryAnswer Nope { get; } = new BinaryAnswer(-1, "no");
        public static BinaryAnswer Maybe { get; } = new BinaryAnswer(0, "maybe");
        public static BinaryAnswer Yep { get; } = new BinaryAnswer(1, "yes");

        public BinaryAnswer(int value, string name) : base(value, name)
        {
        }
    }
}