﻿using System;
using System.Collections.Generic;
using ByteBee.Enums;
using ByteBee.Exceptions;
using NUnit.Framework;

namespace ByteBeeTests.DataTypes
{
    sealed class FooEnum : BeeEnum<FooEnum, int>
    {
        private FooEnum(int value, string name) : base(value, name)
        {
        }

        public static FooEnum One { get; } = new FooEnum(1, nameof(One));
        public static FooEnum Two { get; } = new FooEnum(2, nameof(Two));
        public static FooEnum Three { get; } = new FooEnum(3, nameof(Three));
    }

    enum BarEnum { One = 1 }

    [TestFixture]
    public sealed class EnumTest
    {
        [Test]
        public void ReturnsAllDefinedEnums()
        {
            IList<FooEnum> result = FooEnum.GetAll();

            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Does.Contain(FooEnum.One));
            Assert.That(result, Does.Contain(FooEnum.Two));
            Assert.That(result, Does.Contain(FooEnum.Three));
        }

        [Test]
        public void ReturnAllDefinedValuesAsIs()
        {
            int bar = FooEnum.Two;

            Assert.That((int)FooEnum.One, Is.EqualTo(1));
            Assert.That(bar, Is.EqualTo(2));
            Assert.That(Convert.ToInt32(FooEnum.Three), Is.EqualTo(3));
        }

        [Test]
        public void ReturnsEnumFromGivenValue()
        {
            var result = (FooEnum)1;

            Assert.That(FooEnum.One, Is.EqualTo(result));
        }

        [Test]
        public void ReturnsEnumGivenNoExplicitPriorUse()
        {
            const string Expected = "One";
            Assert.AreEqual(Expected, FooEnum.ByName(Expected).Name);
        }

        [Test]
        public void ReturnsEnumGivenExplicitPriorUse()
        {
            string expected = FooEnum.One.Name;
            Assert.AreEqual(expected, FooEnum.ByName(expected).Name);
        }

        [Test]
        public void ReturnsEnumGivenMatchingName()
        {
            Assert.AreEqual(FooEnum.One, FooEnum.ByName("One"));
        }

        [Test]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => FooEnum.ByName(String.Empty));
        }

        [Test]
        public void ThrowsGivenNull()
        {
            Assert.Throws<ArgumentNullException>(() => FooEnum.ByName(null));
        }

        [Test]
        public void ThrowsGivenNonMatchingString()
        {
            Assert.Throws<EnumNotFoundException>(() => FooEnum.ByName("Doesn't Exist"));
        }

        [Test]
        public void ThrowsWithExpectedMessageGivenNonMatchingString()
        {
            const string Name = "Doesn't Exist";
            string expected = $"No FooEnum with name \"{Name}\" found.";
            string actual = "";

            try
            {
                FooEnum.ByName(Name);
            }
            catch (EnumNotFoundException ex)
            {
                actual = ex.Message;
            }

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnsEnumGivenMatchingValue()
        {
            Assert.AreEqual(FooEnum.One, FooEnum.ByValue(1));
        }

        [Test]
        public void ThrowsGivenNonMatchingValue()
        {
            Assert.Throws<EnumNotFoundException>(() => FooEnum.ByValue(-1));
        }

        [Test]
        public void ThrowsWithExpectedMessageGivenNonMatchingValue()
        {
            const string Expected = "No FooEnum with value -1 found.";
            string actual = "";

            try
            {
                FooEnum.ByValue(-1);
            }
            catch (EnumNotFoundException ex)
            {
                actual = ex.Message;
            }

            Assert.AreEqual(Expected, actual);
        }

        [Test]
        public void ReturnsDefaultEnumGivenNonMatchingValue()
        {
            FooEnum defaultEnum = FooEnum.One;

            Assert.AreEqual(defaultEnum, FooEnum.ByValue(-1, defaultEnum));
        }

        [Test]
        public void ReturnsValueOfGivenEnum()
        {
            int result = FooEnum.One;

            Assert.AreEqual(FooEnum.One.Value, result);
        }

        [Test]
        public void ReturnsFormattedNameAndValue()
        {
            Assert.AreEqual("One (1)", FooEnum.One.ToString());
            Assert.AreEqual("Two (2)", FooEnum.Two.ToString());
            Assert.AreEqual("Three (3)", FooEnum.Three.ToString());
        }

        [Test]
        public void CompareEnumWithPimped()
        {
            var one = (FooEnum)(int)BarEnum.One;

            Assert.AreEqual("One (1)", one.ToString());
        }
    }
}
