using KukSoft.ToolKit.Audit;
using KukSoft.ToolKit.DataTypes;
using KukSoft.ToolKit.Logger;
using KukSoft.ToolKit.Security;
using KukSoft.ToolKit.Utilities;

namespace KukSoft.ToolKit
{
    public static partial class Fancy
    {
        public static IGuard guard => Microkernel.Instance.Resolve<IGuard>();
        public static IInflector inflector => Microkernel.Instance.Resolve<IInflector>();

        public static ISwitch<TObject> choose<TObject>(TObject obj) => new Switch<TObject>(obj);

        public static IAuditor<TObject> auditor<TObject>() => new StandardAuditor<TObject>();

        public static IEncryptionFactory encryption => Microkernel.Instance.Resolve<IEncryptionFactory>();

        public static ILogger logger => new StandardLogger();
    }
}