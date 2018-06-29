namespace KukSoft.ToolKit.MessageBus
{
    public class MessageBusSeq : MessageBusBase
    {
        protected override void Invoke<TMessage>(TMessage message, IHandle<TMessage> subscriber)
        {
            subscriber.Handle(message);
        }
    }
}