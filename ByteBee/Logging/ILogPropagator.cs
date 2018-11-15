namespace ByteBee.Logging
{
    public interface ILogPropagator
    {
        ILogPropagator FilterWith(ILogFilter filter);
        void Propagate(LogMessage message);
    }
}
