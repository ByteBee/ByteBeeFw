using ByteBee.Exceptions;

namespace ByteBee.Protection
{
    public static class StringProtection
    {
        public static GuardArgument<string> IsNotEmpty(this GuardArgument<string> arg, string message = null)
        {
            if (string.IsNullOrEmpty(arg.Value))
            {
                string m = message ?? $"{arg.Name} must not be empty.";
                throw new GuardArgumentIsEmptyException(m);
            }

            return arg;
        }
        
        public static GuardArgument<string> IsEmpty(this GuardArgument<string> arg, string message = null)
        {
            if (!string.IsNullOrEmpty(arg.Value))
            {
                string m = message ?? $"{arg.Name} must be empty.";
                throw new GuardArgumentIsNotEmptyException(m);
            }

            return arg;
        }

        public static GuardArgument<string> IsNotWhitespace(this GuardArgument<string> arg, string message = null)
        {
            if (string.IsNullOrEmpty(arg.Value))
            {
                string m = message ?? $"{arg.Name} must be empty.";
                throw new GuardArgumentIsNotEmptyException(m);
            }

            return arg;
        }
    }
}