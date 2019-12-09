using System;
using System.Security.AccessControl;
using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Range
{
    public class TestMin
    {
        [Test]
        public void IfOnlyTwoParametersAreGivenAndTheFirstOneIsRelevant()
        {
            short first = 2;
            short last = 7;
            short expected = first;

            short actual = MathRange.Min(first, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfOnlyTwoParametersAreGivenAndTheLastOneIsRelevant()
        {
            short first = 42;
            short last = 7;
            short expected = last;

            short actual = MathRange.Min(first, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeParametersAreGivenAndTheFirstOneIsRelevant()
        {
            short first = 2;
            short middle = 5;
            short last = 7;
            short expected = first;

            short actual = MathRange.Min(first, middle, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeParametersAreGivenAndTheMiddleOneIsRelevant()
        {
            short first = 2;
            short middle = -5;
            short last = 7;
            short expected = middle;

            short actual = MathRange.Min(first, middle, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeParametersAreGivenAndTheLastOneIsRelevant()
        {
            short first = 2;
            short middle = 5;
            short last = -7;
            short expected = last;

            short actual = MathRange.Min(first, middle, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WhatIfAllNumbersAreZero()
        {
            byte number = 0;

            byte actual = MathRange.Min(number, number, number);

            Assert.AreEqual(number, actual);
        }

        [Test]
        public void WhatIfAllNumbersAreTheSame()
        {
            byte number = 42;

            byte actual = MathRange.Min(number, number, number);

            Assert.AreEqual(number, actual);
        }

        [Test]
        public void WhatIfWeHaveInfinity()
        {
            double result = MathRange.Min(double.PositiveInfinity, double.NegativeInfinity);

            Assert.AreEqual(double.NegativeInfinity,result);
        }
    }
}