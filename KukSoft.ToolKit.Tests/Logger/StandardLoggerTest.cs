using System;
using KukSoft.ToolKit.Logger;
using NUnit.Framework;
using static KukSoft.ToolKit.Fancy;

namespace KukSoft.ToolKit.Tests.Logger
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
