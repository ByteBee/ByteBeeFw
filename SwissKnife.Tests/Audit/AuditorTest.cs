using NUnit.Framework;
using SwissKnife.Audit;
using SwissKnife.DataTypes;
using static SwissKnife.Fancy;

namespace SwissKnife.Tests.Audit
{
    [TestFixture]
    public class AuditorTest
    {
        [Test]
        public void TestInitialisation()
        {
            Assert.Throws<AuditException>(() =>
            {
                try
                {
                    auditor<Vector2D>()
                        .MustPass(v => v.X > 2, "X muss größer als 2 sein")
                        .Audit(new Vector2D(2, 4));
                }
                catch (AuditException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw;
                }
            });
        }

        [Test]
        public void TestCustomAuditor()
        {
            Assert.Throws<AuditException>(() =>
            {
                try
                {
                    var a = new VectorAuditorStub();
                    a.Audit(new Vector2D(-2, -4));
                }
                catch (AuditException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw;
                }
            });
        }

        [Test]
        public void TestNestedAudit()
        {
            Assert.Throws<AuditException>(() =>
            {
                try
                {
                    auditor<Vector2D>()
                       .MustPass(v => v.X > 2, "X muss größer als 2 sein")
                       .SubSequence(new VectorAuditorStub(), new Vector2D(-2, -4), "Werte sollen positiv sein")
                       .MustFail(v => v.Y == 4, "Y ist 4")
                       .SubSequence(new VectorAuditorStub(), new Vector2D(-2, 4), "Werte sollen positiv sein")
                       .Audit(new Vector2D(2, 4));
                }
                catch (AuditException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw;
                }
            });
        }

        class VectorAuditorStub : Auditor<Vector2D>
        {
            protected override void Checklist(Vector2D obj)
            {
                MustPass(v => v.Y > 0, "Y muss positiv sein");
                MustPass(v => v.X > 0, "X muss positiv sein");

                SubSequence(new VectorAuditorNotNegativeStub(), 42, "hallo");
            }
        }
        class VectorAuditorNotNegativeStub : Auditor<int>
        {
            protected override void Checklist(int zahl)
            {
                MustPass(i => i < 0, "zahl muss negativ sein.");
            }
        }
    }
}
