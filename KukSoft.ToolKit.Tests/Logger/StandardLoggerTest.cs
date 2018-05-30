using NUnit.Framework;
using System;

namespace KukSoft.ToolKit.Logger.Tests
{
    [TestFixture]
    class StandardLoggerTest
    {
        [Test]
        public void TestErrorLogOutput()
        {
            var m = new FakeManager();

            ILogger logger = Fancy.Logger(Fancy.LogStrategies.Console());

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
