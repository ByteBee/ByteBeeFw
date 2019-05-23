using System;

namespace ByteBee.MathClause
{
    public static class FuncMathPower
    {
        public static double Pow(this IMathClause math, double x, double @base)
        {
            return Math.Pow(x, @base);
        }

        public static double Pow2(this IMathClause math, double x)
        {
            return math.Pow(x, 2);
        }

        public static double Pow3(this IMathClause math, double x)
        {
            return math.Pow(x, 3);
        }

        public static double Pow8(this IMathClause math, double x)
        {
            return math.Pow(x, 8);
        }

        public static double Pow10(this IMathClause math, double x)
        {
            return math.Pow(x, 10);
        }

        public static double Pow16(this IMathClause math, double x)
        {
            return math.Pow(x, 16);
        }
    }
}