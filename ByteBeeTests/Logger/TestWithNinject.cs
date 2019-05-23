//using ByteBee.Logging;
//using ByteBee.Logging.Impl;
//using ByteBee.Logging.Impl.Propagator;
//using Ninject;
//using NUnit.Framework;

//namespace ByteBeeTests.Logger
//{
//    public class MyLogFormatter : ILogFormatter
//    {
//        public string Format(LogMessage message)
//        {
//            return message.Message;
//        }
//    }

//    [TestFixture]
//    public class TestWithNinject
//    {
//        [Test]
//        public void InitInMemoryLogger()
//        {
//            IKernel kernel = new StandardKernel();
//            kernel.Bind<ILogger>().To<StandardLogger>();
//            kernel.Bind<ILogPropagator>().To<ConsolePropagator>();
//            kernel.Bind<ILogPropagator>().To<MemoryPropagator>().InSingletonScope();
//            kernel.Bind<ILogFormatter>().To<MyLogFormatter>().InSingletonScope();

//            ILogger logger = kernel.Get<ILogger>();

//            logger.Info("log me");
//        }
//    }
//}
