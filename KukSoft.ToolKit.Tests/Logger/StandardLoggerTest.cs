using KukSoft.ToolKit.Logger;
using NUnit.Framework;
using System;

namespace KukSoft.ToolKit.Tests.Logger
{
    [TestFixture]
    class StandardLoggerTest
    {
        [Test]
        public void TestErrorLogOutput()
        {
            var m = new FakeManager();
            ILogger logger = Fancy.Logger(new LogIntoConsole());

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
