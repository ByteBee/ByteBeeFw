using ByteBee.Core.GuardClause;
using ByteBee.Core.MathClause;

namespace ByteBee.Core
{
    public static class Bee
    {
        public static IGuardClause Guard { get; } = new BeeGuardImpl();
        public static IMathClause Math { get; } = new BeeMathImpl();

    }
}