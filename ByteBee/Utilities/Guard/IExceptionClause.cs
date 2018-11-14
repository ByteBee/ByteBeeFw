namespace ByteBee.Utilities.Guard
{
    public interface IExceptionClause
    {
        void ArgumentException(string message);
        void NotImplementedException(string message);
        void NotSupportedException(string message);
    }
}