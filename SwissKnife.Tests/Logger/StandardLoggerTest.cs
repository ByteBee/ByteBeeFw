using System;
using NUnit.Framework;
using SwissKnife.Logging;
using static SwissKnife.Fancy;

namespace SwissKnife.Tests.Logger
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
