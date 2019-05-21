namespace ByteBee.GuardClause
{
    public class Guard
    {
        private class GuardAgainstClauseImpl : IGuardAgainstClause
        {
        }

        public static IGuardAgainstClause Against { get; } = new GuardAgainstClauseImpl();

        private Guard()
        {
        }
    }
}