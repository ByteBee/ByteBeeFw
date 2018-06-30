using SwissKnife.DataTypes;
using SwissKnife.Logging;
using SwissKnife.Security;
using SwissKnife.Utilities;
using SwissKnife.Validating;

// ReSharper disable InconsistentNaming

namespace SwissKnife
{
    public static partial class Fancy
    {
        public static IGuard guard => Microkernel.Instance.Resolve<IGuard>();
        public static IInflector inflector => Microkernel.Instance.Resolve<IInflector>();

        public static ISwitch<TObject> choose<TObject>(TObject obj) => new Switch<TObject>(obj);

        public static IValidator<TObject> validation<TObject>() => new ConcrValidator<TObject>();

        public static IEncryptionFactory encryption => Microkernel.Instance.Resolve<IEncryptionFactory>();

        public static ILogger logger => new StandardLogger();
        public static IPath path => Microkernel.Instance.Resolve<IPath>();
        public static IFile file => Microkernel.Instance.Resolve<IFile>();
        public static IGuid guid => Microkernel.Instance.Resolve<IGuid>();
        public static IDateTime dateTime => Microkernel.Instance.Resolve<IDateTime>();
        public static IDirectory directory => Microkernel.Instance.Resolve<IDirectory>();
        public static IMath math => Microkernel.Instance.Resolve<IMath>();
    }
}