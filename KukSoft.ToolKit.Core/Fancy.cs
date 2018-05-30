using KukSoft.ToolKit.DataTypes;
using KukSoft.ToolKit.Logger;
using KukSoft.ToolKit.MessageBus;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KukSoft.ToolKit.Public")]

namespace KukSoft.ToolKit
{
    public static class Fancy
    {
        public static ISwitch<TObject> Switch<TObject>(TObject obj)
            => new Switch<TObject>(obj);

        public static IMessageBus MessageBus(bool useAsynchron = false) 
            => useAsynchron ? new MessageBusAsync() : new MessageBusSeq() as IMessageBus;

        public static ILogger Logger(ILogStrategy handler)
            => Logger(new[] { handler });

        public static ILogger Logger(ILogStrategy[] handler)
            => new StandardLogger(handler);

        public static ILogStrategyFactory LogStrategies
            => LogStrategyFactory.Instance;
    }
}
