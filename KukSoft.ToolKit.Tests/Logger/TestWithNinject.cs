using KukSoft.ToolKit.Logger;
using KukSoft.ToolKit.Logger.Handler;
using Ninject;
using NUnit.Framework;

namespace KukSoft.ToolKit.Tests.Logger
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

            kernel.Bind<ILogger>().To<StandardLogger>();
            kernel.Bind<ILogStrategy>().To<LogIntoConsole>();
            kernel.Bind<ILogStrategy>().To<LogIntoMemory>().InSingletonScope();
            kernel.Bind<ILogFormatter>().To<MyLogFormatter>().InSingletonScope();

            ILogger logger = kernel.Get<ILogger>();

            logger.Info("log me");
        }
    }
}
