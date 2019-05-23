using System;

namespace ByteBee.MathClause
{
    public static class FuncMathRound
    {
        public static double Round(this IMathClause math, double value)
        {
            return Math.Round(value);
        }

        public static double Round(this IMathClause math, double value, int digits)
        {
            return Math.Round(value, digits);
        }

        public static double Round(this IMathClause math, double value, MidpointRounding mode)
        {
            return Math.Round(value, mode);
        }

        public static double Round(this IMathClause math, double value, int digits, MidpointRounding mode)
        {
            return Math.Round(value, digits, mode);
        }

        public static decimal Round(this IMathClause math, decimal value)
        {
            return Math.Round(value);
        }

        public static decimal Round(this IMathClause math, decimal value, int decimals)
        {
            return Math.Round(value, decimals);
        }

        public static decimal Round(this IMathClause math, decimal value, MidpointRounding mode)
        {
            return Math.Round(value, mode);
        }

        public static decimal Round(this IMathClause math, decimal value, int decimals, MidpointRounding mode)
        {
            return Math.Round(value, decimals, mode);
        }

        public static double Round1(this IMathClause math, double value)
        {
            return math.Round(value, 1);
        }

        public static double Round1(this IMathClause math, double value, MidpointRounding mode)
        {
            return math.Round(value, 1, mode);
        }

        public static decimal Round1(this IMathClause math, decimal value)
        {
            return math.Round(value, 1);
        }

        public static decimal Round1(this IMathClause math, decimal value, MidpointRounding mode)
        {
            return math.Round(value, 1, mode);
        }

        public static double Round2(this IMathClause math, double value)
        {
            return math.Round(value, 2);
        }

        public static double Round2(this IMathClause math, double value, MidpointRounding mode)
        {
            return math.Round(value, 2, mode);
        }

        public static decimal Round2(this IMathClause math, decimal value)
        {
            return math.Round(value, 2);
        }

        public static decimal Round2(this IMathClause math, decimal value, MidpointRounding mode)
        {
            return math.Round(value, 2, mode);
        }

        public static double Round3(this IMathClause math, double value)
        {
            return math.Round(value, 3);
        }

        public static double Round3(this IMathClause math, double value, MidpointRounding mode)
        {
            return math.Round(value, 3, mode);
        }

        public static decimal Round3(this IMathClause math, decimal value)
        {
            return math.Round(value, 3);
        }

        public static decimal Round3(this IMathClause math, decimal value, MidpointRounding mode)
        {
            return math.Round(value, 3, mode);
        }
    }
}