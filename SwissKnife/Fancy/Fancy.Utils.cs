using SwissKnife.Logging;
using SwissKnife.Mathematics.Functions;
using SwissKnife.Security;
using SwissKnife.Utilities;
using SwissKnife.Utilities.Guard;
using SwissKnife.Validating;

namespace SwissKnife
{
    public static partial class Fancy
    {
        public static IGuardClause guard => Microkernel.Instance.Resolve<IGuardClause>();
        public static IInflector inflector => Microkernel.Instance.Resolve<IInflector>();

        public static ISwitch<TObject> choose<TObject>(TObject obj) => new Switch<TObject>(obj);

        public static IEncryptionFactory encryption => Microkernel.Instance.Resolve<IEncryptionFactory>();

        public static ILogger logger => new StandardLogger();
        public static IMathFunctions math => Microkernel.Instance.Resolve<IMathFunctions>();
        public static AbstrValidator<TObject> validator<TObject>() => new StandardValidator<TObject>();
    }
}