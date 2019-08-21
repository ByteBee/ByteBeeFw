namespace ByteBee.MessageBus
{
    public interface IHandle<in TMessage> where TMessage : IMessage
    {
        void Handle(TMessage message);
    }
}
