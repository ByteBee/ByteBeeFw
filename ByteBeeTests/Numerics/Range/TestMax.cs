using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Range
{
    public class TestMax
    {
        [Test]
        public void IfOnlyTwoParametersAreGivenAndTheFirstOneIsRelevant()
        {
            short first = 5;
            short last = -5;
            short expected = first;

            short actual = MathRange.Max(first, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfOnlyTwoParametersAreGivenAndTheLastOneIsRelevant()
        {
            short first = -5;
            short last = 5;
            short expected = last;

            short actual = MathRange.Max(first, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeParametersAreGivenAndTheFirstOneIsRelevant()
        {
            short first = 5;
            short middle = -5;
            short last = 0;
            short expected = first;

            short actual = MathRange.Max(first, middle, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeParametersAreGivenAndTheMiddleOneIsRelevant()
        {
            short first = -5;
            short middle = 5;
            short last = 0;
            short expected = middle;

            short actual = MathRange.Max(first, middle, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfThreeParametersAreGivenAndTheLastOneIsRelevant()
        {
            short first = 0;
            short middle = -5;
            short last = 5;
            short expected = last;

            short actual = MathRange.Max(first, middle, last);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WhatIfAllNumbersAreZero()
        {
            byte number = 0;

            byte actual = MathRange.Max(number, number, number);

            Assert.AreEqual(number, actual);
        }

        [Test]
        public void WhatIfAllNumbersAreTheSame()
        {
            byte number = 42;

            byte actual = MathRange.Max(number, number, number);

            Assert.AreEqual(number, actual);
        }

        [Test]
        public void WhatIfWeHaveInfinity()
        {
            double result = MathRange.Max(double.PositiveInfinity, double.NegativeInfinity);

            Assert.AreEqual(double.PositiveInfinity, result);
        }
    }
}