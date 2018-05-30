using KukSoft.ToolKit.DataTypes;
using NUnit.Framework;

namespace KukSoft.ToolKit.Audit.Tests
{
    [TestFixture]
    public class AuditorTest
    {
        [Test]
        public void TestInitialisation()
        {
            Assert.Throws<AuditException>(() =>
            {
                Fancy.Auditor<Vector2D>()
                    .MustPass(v => v.X > 2, "X muss größer als 2 sein")
                    .Audit(new Vector2D(2, 4));
            });
        }

        [Test]
        public void TestCustomAuditor()
        {
            Assert.Throws<AuditException>(() =>
            {
                var a = new FakeAudit();
                a.Audit(new Vector2D(-2, -4));
            });
        }

        [Test]
        public void TestNestedAudit()
        {
            Assert.Throws<AuditException>(() =>
            {
                Fancy.Auditor<Vector2D>()
                    .MustPass(v => v.X > 2, "X muss größer als 2 sein")
                    .SubSequence(new FakeAudit(), new Vector2D(-2, -4), "Werte sollen positiv sein")
                    .MustFail(v => v.Y == 4, "Y ist 4")
                    .SubSequence(new FakeAudit(), new Vector2D(-2, 4), "Werte sollen positiv sein")
                    .Audit(new Vector2D(2, 4));
            });
        }
    }
}
