namespace KukSoft.ToolKit.MessageBus.Public
{
    public class MessageBusAsync : IMessageBus
    {
        private IMessageBus _messageBus;

        public MessageBusAsync() 
            => _messageBus = new MessageBus.MessageBusAsync();

        public void Publish<TMessage>(TMessage message) where TMessage : IMessage
            => _messageBus.Publish(message);

        public void Register(object subscriber)
            => _messageBus.Register(subscriber);
    }
}
