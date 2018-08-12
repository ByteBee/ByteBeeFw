using NUnit.Framework;
using SwissKnife.Mathematics.Vector;
using SwissKnife.Validating;
using System;
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
                    validator<Vector2I>()
                        .ShouldBeTrue(v => v.X > 2, "X muss größer als 2 sein")
                        .ValidateAndThrow(new Vector2I(2, 4));
                }
                catch (Exception ex)
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
                    a.ValidateAndThrow(new Vector2I(-2, -4));
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

            ValidationResult res = validator<Vector2I>()
                .ShouldBeTrue(v => v.X > 2, "X muss größer als 2 sein")
                .RuleSet(new VectorValidatorStub(), new Vector2I(-2, -4), "Werte sollen positiv sein")
                .ShouldBeFalse(v => v.Y == 4, "Y ist 4")
                .RuleSet(new VectorValidatorStub(), new Vector2I(-2, 4), "Werte sollen positiv sein")
                .Validate(new Vector2I(2, 4));


            Console.WriteLine(res);
            Assert.False(res.IsValid);

        }

        class VectorValidatorStub : AbstrValidator<Vector2I>
        {
            protected override void DefineRules(Vector2I obj)
            {
                ShouldBeTrue(v => v.Y > 0, "Y muss positiv sein");
                ShouldBeTrue(v => v.X > 0, "X muss positiv sein");
                RuleSet(new VectorNotNegativeValidatorStub(), 42, "hallo");
            }
        }

        class VectorNotNegativeValidatorStub : AbstrValidator<int>
        {
            protected override void DefineRules(int zahl)
            {
                ShouldBeTrue(i => i < 0, "zahl muss negativ sein.");
            }
        }
    }
}
