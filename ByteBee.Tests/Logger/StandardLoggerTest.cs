using System;
using ByteBee;
using ByteBee.Logging.Impl.Propagator;
using NUnit.Framework;

namespace ByteBeeTests.Logger
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
