using KukSoft.ToolKit.Audit;
using KukSoft.ToolKit.DataTypes;
using KukSoft.ToolKit.Logger;
using KukSoft.ToolKit.Security;
using KukSoft.ToolKit.Utilities;

namespace KukSoft.ToolKit
{
    public static partial class Fancy
    {
        public static IGuard Guard => Microkernel.Instance.Resolve<IGuard>();
        public static IInflector Inflector => Microkernel.Instance.Resolve<IInflector>();

        public static ISwitch<TObject> Switch<TObject>(TObject obj) => new Switch<TObject>(obj);

        public static IAuditor<TObject> Auditor<TObject>() => new StandardAuditor<TObject>();

        public static IEncryptionFactory Encryption => Microkernel.Instance.Resolve<IEncryptionFactory>();

        public static ILogger Logger => new StandardLogger();
    }
}