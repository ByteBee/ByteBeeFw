using System;
using ByteBee;
using ByteBee.Exceptions;
using ByteBee.Protection;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace ByteBeeTests.Protection
{
    [TestFixture]
    public sealed class TestStringOperations
    {
        [Test]
        public void ArgumentMustNotBeEmpty()
        {
            string name = Guard.Ensure("Jonny").IsNotEmpty();

            TestDelegate emptyName = () => Guard.Ensure("").IsNotEmpty();

            Assert.AreSame("Jonny", name);
            Assert.Throws<GuardArgumentIsEmptyException>(emptyName);
        }

        [Test]
        public void ArgumentMustBeEmpty()
        {
            string emptyString = Guard.Ensure("").IsEmpty();

            TestDelegate someName = () => Guard.Ensure("Jonny").IsEmpty();

            Assert.AreSame(string.Empty, emptyString);
            Assert.Throws<GuardArgumentIsNotEmptyException>(someName);
        }

        [Test]
        public void ArgumentMustNotBeWhitespace()
        {
            string whitespace = Guard.Ensure("hello world").IsNotWhitespace();

            Assert.AreEqual(" ", whitespace);
        }

        [Test]
        public void ArgumentMustBeWhitespace()
        {
            Assert.Fail();
        }

        
        [Test]
        public void ArgumentMustBeAtLeastSevenCharactersLong()
        {
            Assert.Fail();
        }

        [Test]
        public void ArgumentMustBeAtMostNineCharactersLong()
        {
            Assert.Fail();
        }

        [Test]
        public void ArgumentMustContainSpecificWord()
        {
            Assert.Fail();
        }

        [Test]
        public void ArgumentMustStartsWithSpecificString()
        {
            Assert.Fail();
        }

        [Test]
        public void ArgumentMustEndsWithSpecificString()
        {
            Assert.Fail();
        }

        [Test]
        public void ArgumentMustMatchTheDefinedRegex()
        {
            Assert.Fail();
        }
    }
}