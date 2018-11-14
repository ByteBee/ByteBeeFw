using System;
using ByteBee.Logging;
using NUnit.Framework;
using static ByteBee.Fancy;

namespace ByteBee.Tests.Logger
{
    [TestFixture]
    class StandardLoggerTest
    {
        [Test]
        public void TestErrorLogOutput()
        {
            var m = new FakeManager();

            logger.Register(new LogIntoConsole());
            
            try
            {
                m.Do();
            }
            catch (Exception ex)
            {
                logger.Error("Big Bang!", ex);
            }
        }
    }
}
