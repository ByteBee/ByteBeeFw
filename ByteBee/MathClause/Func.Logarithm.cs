using System;

namespace ByteBee.Core.MathClause
{
    public static class FuncMathLogarithm
    {
        public static double LogE(this IMathClause math, double d)
        {
            return Math.Log(d);
        }

        public static double Log2(this IMathClause math, double d)
        {
            return math.Log(d, 2);
        }

        public static double Log8(this IMathClause math, double d)
        {
            return math.Log(d, 8);
        }

        public static double Log10(this IMathClause math, double d)
        {
            return math.Log(d, 10);
        }

        public static double Log16(this IMathClause math, double d)
        {
            return math.Log(d, 16);
        }

        public static double Log(this IMathClause math, double a, double @base)
        {
            return Math.Log(a, @base);
        }
    }
}