using SwissKnife.Audit;
using SwissKnife.DataTypes;
using SwissKnife.Logger;
using SwissKnife.Security;
using SwissKnife.Utilities;

namespace SwissKnife
{
    public static partial class Fancy
    {
        public static IGuard guard => Microkernel.Instance.Resolve<IGuard>();
        public static IInflector inflector => Microkernel.Instance.Resolve<IInflector>();

        public static ISwitch<TObject> choose<TObject>(TObject obj) => new Switch<TObject>(obj);

        public static IAuditor<TObject> auditor<TObject>() => new StandardAuditor<TObject>();

        public static IEncryptionFactory encryption => Microkernel.Instance.Resolve<IEncryptionFactory>();

        public static ILogger logger => new StandardLogger();
        public static IPath path => Microkernel.Instance.Resolve<IPath>();
        public static IFile file => Microkernel.Instance.Resolve<IFile>();
        public static IGuid guid => Microkernel.Instance.Resolve<IGuid>();
    }
}