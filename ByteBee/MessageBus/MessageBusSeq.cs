namespace ByteBee.MessageBus
{
    public class MessageBusSeq : MessageBusBase
    {
        /// <inheritdoc />
        protected override void Invoke<TMessage>(TMessage message, IHandle<TMessage> subscriber)
        {
            subscriber.Handle(message);
        }
    }
}