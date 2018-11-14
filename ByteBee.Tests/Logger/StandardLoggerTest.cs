using System;
using ByteBee.Logging;
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

            Bee.Logger.Register(new LogIntoConsole());
            
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
