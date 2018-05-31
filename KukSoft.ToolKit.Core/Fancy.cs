using KukSoft.ToolKit.Audit;
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

        public static ILogger Logger { get; } = new StandardLogger();

        public static ILogStrategyFactory LogStrategies { get; } = new LogStrategyFactory();

        public static IAuditor<TObject> Auditor<TObject>()
            => new AuditorImpl<TObject>();

        public static IGuard Guard { get; } = new Guard();

        public static IInflector Inflector { get; } = new Inflector();
    }
}
