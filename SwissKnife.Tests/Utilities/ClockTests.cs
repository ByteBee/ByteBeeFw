using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using NUnit.Framework;

namespace SwissKnife.Tests.Utilities
{
    [TestFixture]
    public class ClockTests
    {
        internal class FreezedClock : SwissKnife.Utilities.DateTimeAdapter
        {
            public FreezedClock(DateTime value)
            {
                Now = value;
            }
            public FreezedClock() : this(DateTime.Now) { }

            public override DateTime Now { get; }
        }
        [Test]
        public void TestForStaticClock()
        {
            FreezedClock clock = new FreezedClock();

            DateTime time = clock.Now;

            Thread.Sleep(500);

            Assert.AreEqual(time, clock.Now);
        }
        
    }
}