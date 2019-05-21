//using System;
//using System.Collections.Generic;
//using ByteBee;
//using ByteBee.Maths.Algebra;
//using ByteBee.Validating;
//using ByteBeeTests.DataTypes;
//using NUnit.Framework;

//namespace ByteBeeTests.Audit
//{
//    [TestFixture]
//    public class AuditorTest
//    {
//        //[Test]
//        //public void TestInitialisation()
//        //{
//        //    Assert.Throws<ObjectNotValidException>(() =>
//        //    {
//        //        try
//        //        {
//        //            validator<Vector2I>()
//        //                .ShouldBeTrue(v => v.X > 2, "X muss größer als 2 sein")
//        //                .ValidateAndThrow(new Vector2I(2, 4));
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            System.Console.WriteLine(ex.Message);
//        //            throw;
//        //        }
//        //    });
//        //}

//        [Test]
//        public void TestCustomAuditor()
//        {
//            Assert.Throws<ObjectNotValidException>(() =>
//            {
//                try
//                {
//                    var a = new VectorValidatorStub();
//                    a.ValidateAndThrow(new Vector3R(-2, -4,0));
//                }
//                catch (ObjectNotValidException ex)
//                {
//                    System.Console.WriteLine(ex.Message);
//                    throw;
//                }
//            });
//        }

//        [Test]
//        public void TestNestedAudit()
//        {
//            var vect = new Vector3R(2, 4,1);
//            AbstractValidator<Vector3R> a = Bee.Validator<Vector3R>();
//            a.RuleFor(v => v.X).Must(i => i > 2).WithMessage("X muss größer als 2 sein");
//            a.RuleFor(v => v.Y).Must(i => i == 4).WithMessage("Y is 4");

//            ValidationResult res = a.Validate(vect);

//            AbstractValidator<Person> personValidator = Bee.Validator<Person>();


//            //.ShouldBeTrue(v => v.X > 2, "")
//            ////.RuleSet(new VectorValidatorStub(), new Vector2I(-2, -4), "Werte sollen positiv sein")
//            //.ShouldBeFalse(v => v.Y == 4, "Y ist 4")
//            ////.RuleSet(new VectorValidatorStub(), new Vector2I(-2, 4), "Werte sollen positiv sein")
//            //.Validate();


//            Console.WriteLine(res);
//            Assert.False(res.IsValid);

//        }

//        class Person
//        {
//            public IList<Adress> Adresses { get; set; }
//        }

//        class Adress
//        {
//            public string City { get; set; }
//        }

//        [Test]
//        public void FluentValidatorTest()
//        {
//            Vector3R vector = new Vector3R(0, 0,0);
//            AbstractValidator<Vector3R> v = Bee.Validator<Vector3R>();

//            v.RuleFor(x => x.Y).NotNull().Must(i => i > 0);
//            v.RuleFor(x => x.X).Must(i => i > 0).WithMessage("X must be greather than zero");

//            ValidationResult res = v.Validate(vector);

//            Console.WriteLine(res);
//            Assert.False(res.IsValid);
//        }

//        class VectorValidatorStub : AbstractValidator<Vector3R>
//        {
//            public VectorValidatorStub()
//            {
//                RuleFor(v => v.Y).Must(BeGreatherThanZero).WithMessage("Y must be greather than zero");
//                RuleFor(v => v.X).Must(BeGreatherThanZero).WithMessage("X must be greather than zero");

//                //RuleSet(new VectorNotNegativeValidatorStub(), 42, "hallo");
//            }

//            private bool BeGreatherThanZero(double i) => i > 0;
//        }

//        class VectorNegativeValidatorStub : AbstractValidator<int>
//        {
//            protected VectorNegativeValidatorStub()
//            {
//                RuleFor(i => i).Must(BeLessThanZero).WithMessage("number must be less than zero");

//                //ShouldBeTrue(i => i < 0, "zahl muss negativ sein.");
//            }

//            private bool BeLessThanZero(int i) => i < 0;
//        }
//    }
//}
