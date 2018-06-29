using Ninject;
using NUnit.Framework;
using SwissKnife.Logger;

namespace SwissKnife.Tests.Logger
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

            kernel.Bind<ILogStrategy>().To<LogIntoConsole>();
            kernel.Bind<ILogStrategy>().To<LogIntoMemory>().InSingletonScope();
            kernel.Bind<ILogFormatter>().To<MyLogFormatter>().InSingletonScope();

            ILogger logger = kernel.Get<ILogger>();

            logger.Info("log me");
        }
    }
}
