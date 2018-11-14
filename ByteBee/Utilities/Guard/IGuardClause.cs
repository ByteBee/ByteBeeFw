using System;

namespace ByteBee.Utilities.Guard
{
    public interface IGuardClause
    {
        IConstraintClause Against { get; }

        IExceptionClause Throws();
        /// <exception>
        ///     <cref>TException</cref>
        /// </exception>
        void Throws<TException>(Func<bool> condition, string message) where TException : Exception;

        /// <exception>
        ///     <cref>TException</cref>
        /// </exception>
        void Throws<TException>(bool condition, string message) where TException : Exception;

        /// <exception>
        ///     <cref>TException</cref>
        /// </exception>
        void Throws<TException>(string message) where TException : Exception;
    }
}
