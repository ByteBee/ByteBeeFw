using System.Threading;

namespace ByteBee.MessageBus
{
    public class MessageBusAsync : MessageBusBase
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