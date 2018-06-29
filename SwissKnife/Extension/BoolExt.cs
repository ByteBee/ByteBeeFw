namespace SwissKnife.Extension
{
    public static class BoolExt
    {
        public static string YepNope(this bool self)
            => self ? "Yes" : "No";

        public static int ToNumber(this bool self)
            => self ? 1 : 0;
    }
}
