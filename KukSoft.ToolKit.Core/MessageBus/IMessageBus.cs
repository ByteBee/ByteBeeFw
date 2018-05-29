namespace KukSoft.ToolKit.MessageBus
{
    public interface IMessageBus
    {
        void Register(object subscriber);
        void Publish<TMessage>(TMessage message) where TMessage : IMessage;
    }
}
