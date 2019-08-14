using System;
using ByteBee;
using ByteBee.Core;
using ByteBee.Core.MathClause;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Func
{
    [TestFixture]
    public class TestLogarithmFunc
    {
        [TestCase(Math.E, 1)]
        public void TestLogE(double testCase, double expected)
        {
            Bee.Math.LogE(testCase)
                .Should().Be(expected);
        }

        [TestCase(1 / 2d, -1)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        [TestCase(1024, 10)]
        public void TestLog2(double testCase, double expected)
        {
            Bee.Math.Log2(testCase)
                .Should().Be(expected);
        }

        [TestCase(1 / 8d, -1)]
        [TestCase(1, 0)]
        [TestCase(8, 1)]
        [TestCase(64, 2)]
        [TestCase(512, 3)]
        public void TestLog8(double testCase, double expected)
        {
            Bee.Math.Log8(testCase)
                .Should().Be(expected);
        }

        [TestCase(1/10d, -1)]
        [TestCase(1, 0)]
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        public void TestLog10(double testCase, double expected)
        {
            Bee.Math.Log10(testCase)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        [TestCase(1/16d,-1)]
        [TestCase(1,0)]
        [TestCase(16,1)]
        [TestCase(256,2)]
        [TestCase(4096,3)]
        public void TestLog16(double testCase, double expected)
        {
            Bee.Math.Log16(testCase)
                .Should().Be(expected);
        }
    }
}