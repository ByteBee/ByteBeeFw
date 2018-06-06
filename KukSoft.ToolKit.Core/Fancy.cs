using KukSoft.ToolKit.Audit;
using KukSoft.ToolKit.DataTypes;
using KukSoft.ToolKit.Logger;
using KukSoft.ToolKit.MessageBus;
using KukSoft.ToolKit.Security;
using KukSoft.ToolKit.Specs;
using KukSoft.ToolKit.Utilities;
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

        public static ILogger Logger 
            => new StandardLogger();

        public static ILogStrategyFactory LogStrategies 
            => new LogStrategyFactory();

        public static IAuditor<TObject> Auditor<TObject>()
            => new AuditorImpl<TObject>();

        public static IGuard Guard => new Guard();

        public static IInflector Inflector => new Inflector();

        public static IEncryptionFactory Encryption 
            => new EncryptionFactory();
    }
}
