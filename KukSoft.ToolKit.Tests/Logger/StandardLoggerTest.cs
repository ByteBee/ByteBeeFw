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

            Fancy.Logger.Register(Fancy.LogStrategies.Console());

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
