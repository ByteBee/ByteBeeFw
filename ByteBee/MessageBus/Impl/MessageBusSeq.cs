namespace ByteBee.MessageBus.Impl
{
    public sealed class MessageBusSeq : AbstractMessageBus
    {
        /// <inheritdoc />
        protected override void Invoke<TMessage>(TMessage message, IHandle<TMessage> subscriber)
        {
            subscriber.Handle(message);
        }
    }
}