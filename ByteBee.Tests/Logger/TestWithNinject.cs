using ByteBee.Logging;
using ByteBee.Logging.Impl;
using ByteBee.Logging.Impl.Propagator;
using Ninject;
using NUnit.Framework;

namespace ByteBee.Tests.Logger
{
    public class MyLogFormatter : ILogFormatter
    {
        public string Format(LogMessage message)
        {
            return message.Message;
        }
    }

    [TestFixture]
    public class TestWithNinject
    {
        [Test]
        public void InitInMemoryLogger()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ILogger>().To<LoggerImpl>();
            kernel.Bind<ILogPropagator>().To<ConsolePropagator>();
            kernel.Bind<ILogPropagator>().To<MemoryPropagator>().InSingletonScope();
            kernel.Bind<ILogFormatter>().To<MyLogFormatter>().InSingletonScope();

            ILogger logger = kernel.Get<ILogger>();

            logger.Info("log me");
        }
    }
}
