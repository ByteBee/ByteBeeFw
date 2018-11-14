using System;

namespace ByteBee.Utilities.Guard
{
    internal class GuardImpl : IGuardClause
    {
        public IConstraintClause Against { get; } = new ConstraintClause();
        public IExceptionClause Throws() => new ExceptionClause();

        public void Throws<TException>(Func<bool> condition, string message) where TException : Exception
            => Throws<TException>(condition(), message);

        public void Throws<TException>(bool condition, string message) where TException : Exception
        {
            if (condition)
            {
                Throws<TException>(message);
            }
        }
        public void Throws<TException>(string message) where TException : Exception
        {
            throw (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
