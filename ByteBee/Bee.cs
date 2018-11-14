using ByteBee.DotNetWrapper;
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

        public static IPathWrapper Path => Microkernel.Instance.Resolve<IPathWrapper>();
        public static IFileWrapper File => Microkernel.Instance.Resolve<IFileWrapper>();
        public static IGuidWrapper Guid => Microkernel.Instance.Resolve<IGuidWrapper>();
        public static IDateTimeWrapper DateTime => Microkernel.Instance.Resolve<IDateTimeWrapper>();
        public static IDirectoryWrapper Directory => Microkernel.Instance.Resolve<IDirectoryWrapper>();
    }
}