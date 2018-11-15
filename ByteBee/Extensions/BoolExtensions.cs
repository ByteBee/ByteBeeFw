namespace ByteBee.Extensions
{
    public static class BoolExtensions
    {
        public static string YepNope(this bool self)
            => self ? "Yes" : "No";

        public static int ToNumber(this bool self)
            => self ? 1 : 0;
    }
}
