namespace ByteBee.Core.Logging
{
    public interface ILogPropagator
    {
        ILogPropagator FilterWith(ILogFilter filter);
        void Propagate(LogMessage message);
    }
}
