using System;
using ByteBee.Logging;
using ByteBee.Logging.Impl.Propagator;
using NUnit.Framework;

namespace ByteBee.Tests.Logger
{
    [TestFixture]
    class StandardLoggerTest
    {
        [Test]
        public void TestErrorLogOutput()
        {
            var m = new FakeManager();

            Bee.Logger.Register(new ConsolePropagator());
            
            try
            {
                m.Do();
            }
            catch (Exception ex)
            {
                Bee.Logger.Error("Big Bang!", ex);
            }
        }
    }
}
