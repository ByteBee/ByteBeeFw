using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KukSoft.ToolKit.Specs.Tests
{
    [TestFixture]
    public class SpecificationTest
    {
        private class StringContainsSpec : Specification<string>
        {
            private readonly string _needle;
            public StringContainsSpec(string needle) => _needle = needle;
            public override bool IsSatisfiedBy(string haystack) => haystack.Contains(_needle);
        }


        [Test]
        public void TestingTheAnd()
        {
            /**
             * 0 0 : 0
             * 0 1 : 0
             * 1 0 : 0
             * 1 1 : 1
             *********/
            Specification<string> specs = new StringConstraint(2, 5)
                .And(new StringContainsSpec("o"));

            Assert.IsFalse(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsFalse(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsFalse(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsTrue(specs.IsSatisfiedBy("foo"), "1:1");
        }

        [Test]
        public void TestingTheOr()
        {
            /**
             * 0 0 : 0
             * 0 1 : 1
             * 1 0 : 1
             * 1 1 : 1
             *********/
            Specification<string> specs = new StringConstraint(2, 5)
                .Or(new StringContainsSpec("o"));

            Assert.IsFalse(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsTrue(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsTrue(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsTrue(specs.IsSatisfiedBy("foo"), "1:1");
        }


        [Test]
        public void TestingTheShorthandAnd()
        {
            /**
             * 0 0 : 0
             * 0 1 : 0
             * 1 0 : 0
             * 1 1 : 1
             *********/
            Specification<string> specs = new StringConstraint(2, 5) * new StringContainsSpec("o");

            Assert.IsFalse(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsFalse(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsFalse(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsTrue(specs.IsSatisfiedBy("foo"), "1:1");
        }

        [Test]
        public void TestingTheShorthandOr()
        {
            /**
             * 0 0 : 0
             * 0 1 : 1
             * 1 0 : 1
             * 1 1 : 1
             *********/
            Specification<string> specs = new StringConstraint(2, 5) + new StringContainsSpec("o");

            Assert.IsFalse(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsTrue(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsTrue(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsTrue(specs.IsSatisfiedBy("foo"), "1:1");
        }

        [Test]
        public void TestingTheXor()
        {
            /**
             * 0 0 : 0
             * 0 1 : 1
             * 1 0 : 1
             * 1 1 : 0
             *********/
            Specification<string> specs = new StringConstraint(2, 5)
                .Xor(new StringContainsSpec("o"));

            Assert.IsFalse(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsTrue(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsTrue(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsFalse(specs.IsSatisfiedBy("foo"), "1:1");
        }

        [Test]
        public void TestingTheNor()
        {
            /**
             * 0 0 : 1
             * 0 1 : 0
             * 1 0 : 0
             * 1 1 : 0
             *********/
            Specification<string> specs = new StringConstraint(2, 5)
                .Nor(new StringContainsSpec("o"));

            Assert.IsTrue(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsFalse(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsFalse(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsFalse(specs.IsSatisfiedBy("foo"), "1:1");
        }


        [Test]
        public void TestingTheNand()
        {
            /**
             * 0 0 : 1
             * 0 1 : 1
             * 1 0 : 1
             * 1 1 : 0
             *********/

            Specification<string> specs = new StringConstraint(2, 5)
                .Nand(new StringContainsSpec("o"));

            Assert.IsTrue(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsTrue(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsTrue(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsFalse(specs.IsSatisfiedBy("foo"), "1:1");
        }

        [Test]
        public void TestingTheXnor()
        {
            /**
             * 0 0 : 1
             * 0 1 : 0
             * 1 0 : 0
             * 1 1 : 1
             *********/
            Specification<string> specs = new StringConstraint(2, 5)
                .Xnor(new StringContainsSpec("o"));

            Assert.IsTrue(specs.IsSatisfiedBy("f"), "0:0");
            Assert.IsFalse(specs.IsSatisfiedBy("o"), "0:1");
            Assert.IsFalse(specs.IsSatisfiedBy("bar"), "1:0");
            Assert.IsTrue(specs.IsSatisfiedBy("foo"), "1:1");
        }

        [Test]
        public void TestingTheExpresion()
        {
            Specification<string> specs = new ExpresionSpec<string>(a => true);
            specs &= new ExpresionSpec<string>(s => s.Contains("foo"));
            specs &= new ExpresionSpec<string>(s => s.Contains("bar"));
            
            Assert.IsTrue(specs.IsSatisfiedBy("foobar"));
            Assert.IsFalse(specs.IsSatisfiedBy("foo"));
            Assert.IsFalse(specs.IsSatisfiedBy("bar"));
            Assert.IsFalse(specs.IsSatisfiedBy("raboof"));
        }
    }
}
