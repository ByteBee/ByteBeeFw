namespace KukSoft.ToolKit.MessageBus.Public
{
    public class MessageBusSeq : IMessageBus
    {
        private IMessageBus _messageBus;

        public MessageBusSeq() 
            => _messageBus = new MessageBus.MessageBusSeq();

        public void Publish<TMessage>(TMessage message) where TMessage : IMessage
            => _messageBus.Publish(message);

        public void Register(object subscriber)
            => _messageBus.Register(subscriber);
    }
}
