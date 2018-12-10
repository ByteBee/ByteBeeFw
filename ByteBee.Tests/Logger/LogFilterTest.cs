using ByteBee.Enums.Impl;
using ByteBee.Logging;
using ByteBee.Logging.Impl;
using ByteBee.Logging.Impl.Filter;
using ByteBee.Logging.Impl.Propagator;
using NUnit.Framework;

namespace ByteBee.Tests.Logger
{
    [TestFixture]
    public class LogFilterTest
    {
        [Test]
        public void AllowAllFilter_ShouldPassEveryRequest()
        {
            var prop = new MemoryPropagator();
            prop.FilterWith(new AllowAllFilter());

            ILogger logger = new StandardLogger();
            logger.Register(prop);
            logger.Log("hello world");

            Assert.That(prop.LogMessageStore, Does.Contain("hello world"));
        }

        [Test]
        public void DenyAllFilter_ShouldBlockEveryRequest()
        {
            var prop = new MemoryPropagator();
            prop.FilterWith(new DenyAllFilter());

            ILogger logger = new StandardLogger();
            logger.Register(prop);
            logger.Log("hello world");

            Assert.That(prop.LogMessageStore, Does.Not.Contain("hello world"));
        }

        [Test]
        public void LogLevelMatchFilter_WithWarning_ShouldOnlyLogWarnings()
        {
            var prop = new MemoryPropagator();
            prop.FilterWith(new LogLevelMatchFilter(LogLevel.Warning));

            ILogger logger = new StandardLogger();
            logger.Register(prop);
            logger.Info("hello world");
            logger.Warning("something happens");

            Assert.That(prop.LogMessageStore, Does.Not.Contain("hello world"));
            Assert.That(prop.LogMessageStore, Does.Contain("something happens"));
        }
    }
}