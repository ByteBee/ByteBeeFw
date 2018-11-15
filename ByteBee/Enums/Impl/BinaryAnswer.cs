namespace ByteBee.Enums.Impl
{
    public class BinaryAnswer : TypedEnum<BinaryAnswer, int>
    {

        public static BinaryAnswer Nope { get; } = new BinaryAnswer(-1, "no");
        public static BinaryAnswer Maybe { get; } = new BinaryAnswer(0, "maybe");
        public static BinaryAnswer Yep { get; } = new BinaryAnswer(1, "yes");

        public BinaryAnswer(int value, string name) : base(value, name)
        {
        }
    }
}