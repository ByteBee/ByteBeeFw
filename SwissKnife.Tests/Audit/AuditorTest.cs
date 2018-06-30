using NUnit.Framework;
using SwissKnife.Mathematics;
using SwissKnife.Mathematics.Vector;
using SwissKnife.Validating;
using static SwissKnife.Fancy;

namespace SwissKnife.Tests.Audit
{
    [TestFixture]
    public class AuditorTest
    {
        [Test]
        public void TestInitialisation()
        {
            Assert.Throws<ObjectNotValidException>(() =>
            {
                try
                {
                    validation<Vector2I>()
                        .MustPass(v => v.X > 2, "X muss größer als 2 sein")
                        .Validate(new Vector2I(2, 4));
                }
                catch (ObjectNotValidException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw;
                }
            });
        }

        [Test]
        public void TestCustomAuditor()
        {
            Assert.Throws<ObjectNotValidException>(() =>
            {
                try
                {
                    var a = new VectorValidatorStub();
                    a.Validate(new Vector2I(-2, -4));
                }
                catch (ObjectNotValidException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw;
                }
            });
        }

        [Test]
        public void TestNestedAudit()
        {
            Assert.Throws<ObjectNotValidException>(() =>
            {
                try
                {
                    validation<Vector2I>()
                       .MustPass(v => v.X > 2, "X muss größer als 2 sein")
                       .SubSequence(new VectorValidatorStub(), new Vector2I(-2, -4), "Werte sollen positiv sein")
                       .MustFail(v => v.Y == 4, "Y ist 4")
                       .SubSequence(new VectorValidatorStub(), new Vector2I(-2, 4), "Werte sollen positiv sein")
                       .Validate(new Vector2I(2, 4));
                }
                catch (ObjectNotValidException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw;
                }
            });
        }

        class VectorValidatorStub : StandardValidator<Vector2I>
        {
            protected override void Checklist(Vector2I obj)
            {
                MustPass(v => v.Y > 0, "Y muss positiv sein");
                MustPass(v => v.X > 0, "X muss positiv sein");

                SubSequence(new VectorNotNegativeValidatorStub(), 42, "hallo");
            }
        }
        class VectorNotNegativeValidatorStub : StandardValidator<int>
        {
            protected override void Checklist(int zahl)
            {
                MustPass(i => i < 0, "zahl muss negativ sein.");
            }
        }
    }
}
