using ByteBee.GuardClause;
using ByteBee.MathClause;

namespace ByteBee
{
    public static class Bee
    {
        public static IGuardClause Guard { get; } = new BeeGuardImpl();
        public static IMathClause Math { get; } = new BeeMathImpl();

    }
}