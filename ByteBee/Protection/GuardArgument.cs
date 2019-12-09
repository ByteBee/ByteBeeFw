namespace ByteBee.Protection
{
    public struct GuardArgument<T>
    {
        private string StupidName => $"The {typeof(T)} argument";
        private readonly string _realName;

        public T Value { get; }

        public string Name => _realName ?? StupidName;

        internal GuardArgument(T value, string name)
        {
            Value = value;
            _realName = name;
        }

        public static implicit operator T(GuardArgument<T> argument)
        {
            return argument.Value;
        }
    }
}