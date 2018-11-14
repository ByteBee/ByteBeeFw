using System.Threading;

namespace ByteBee.MessageBus.Impl
{
    public sealed class MessageBusAsync : AbstractMessageBus
    {
        /// <inheritdoc />
        protected override void Invoke<TMessage>(TMessage message, IHandle<TMessage> subscriber)
        {
            SynchronizationContext syncContext = SynchronizationContext.Current;

            if (syncContext == null)
            {
                syncContext = new SynchronizationContext();
            }

            syncContext.Post(s => subscriber.Handle(message), null);
        }
    }
}