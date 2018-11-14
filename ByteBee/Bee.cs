using ByteBee.Adapter;
using ByteBee.Logging;
using ByteBee.Mathematics.Functions;
using ByteBee.Security;
using ByteBee.Utilities;
using ByteBee.Utilities.Guard;
using ByteBee.Validating;

namespace ByteBee
{
    public static class Bee
    {
        public static IGuardClause Guard { get; } = Microkernel.Instance.Resolve<IGuardClause>();

        public static IInflector Inflector => Microkernel.Instance.Resolve<IInflector>();

        public static ISwitch<TObject> Choose<TObject>(TObject obj) => new Switch<TObject>(obj);

        public static IEncryptionFactory Encryption => Microkernel.Instance.Resolve<IEncryptionFactory>();

        public static ILogger Logger => new StandardLogger();
        public static IMathFunctions Math => Microkernel.Instance.Resolve<IMathFunctions>();
        public static AbstrValidator<TObject> Validator<TObject>() => new StandardValidator<TObject>();

        public static IPath Path => Microkernel.Instance.Resolve<IPath>();
        public static IFile File => Microkernel.Instance.Resolve<IFile>();
        public static IGuid Guid => Microkernel.Instance.Resolve<IGuid>();
        public static IDateTime DateTime => Microkernel.Instance.Resolve<IDateTime>();
        public static IDirectory Directory => Microkernel.Instance.Resolve<IDirectory>();
    }
}