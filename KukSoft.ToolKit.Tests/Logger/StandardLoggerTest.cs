using System;
using KukSoft.ToolKit.Logger;
using NUnit.Framework;

namespace KukSoft.ToolKit.Tests.Logger
{
    [TestFixture]
    class StandardLoggerTest
    {
        [Test]
        public void TestErrorLogOutput()
        {
            var m = new FakeManager();

            Fancy.Logger.Register(new LogIntoConsole());

            try
            {
                m.Do();
            }
            catch (Exception ex)
            {
                Fancy.Logger.Error("Big Bang!", ex);
            }
        }
    }
}
