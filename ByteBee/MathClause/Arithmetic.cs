using System;
using ByteBee.GuardClause;

namespace ByteBee.MathClause
{
    public static class MathFunctions1
    {
        public static decimal Ceiling(this IMathClause math,decimal d) => System.Math.Ceiling(d);

        public static double Ceiling(this IMathClause math, double a) => System.Math.Ceiling(a);

        public static decimal Floor(this IMathClause math, decimal d) => System.Math.Floor(d);

        public static double Floor(this IMathClause math, double d) => System.Math.Floor(d);
        
        public static sbyte Abs(this IMathClause math, sbyte value) => System.Math.Abs(value);

        public static short Abs(this IMathClause math, short value) => System.Math.Abs(value);

        public static int Abs(this IMathClause math, int value) => System.Math.Abs(value);

        public static long Abs(this IMathClause math, long value) => System.Math.Abs(value);

        public static float Abs(this IMathClause math, float value) => System.Math.Abs(value);

        public static double Abs(this IMathClause math, double value) => System.Math.Abs(value);

        public static decimal Abs(this IMathClause math, decimal value) => System.Math.Abs(value);

        public static int Sign(this IMathClause math, sbyte value) => System.Math.Sign(value);

        public static int Sign(this IMathClause math, short value) => System.Math.Sign(value);

        public static int Sign(this IMathClause math, int value) => System.Math.Sign(value);

        public static int Sign(this IMathClause math, long value) => System.Math.Sign(value);

        public static int Sign(this IMathClause math, float value) => System.Math.Sign(value);

        public static int Sign(this IMathClause math, double value) => System.Math.Sign(value);

        public static int Sign(this IMathClause math, decimal value) => System.Math.Sign(value);

        public static double Exp(this IMathClause math, double d) => System.Math.Exp(d);

        private static readonly long[] _factValues =
        {
            /*  0 */ 1,
            /*  1 */ 1,
            /*  2 */ 2,
            /*  3 */ 6,
            /*  4 */ 24,
            /*  5 */ 120,
            /*  6 */ 720,
            /*  7 */ 5040,
            /*  8 */ 40320,
            /*  9 */ 362880,
            /* 10 */ 3628800,
            /* 11 */ 39916800,
            /* 12 */ 479001600,
            /* 13 */ 6227020800,
            /* 14 */ 87178291200,
            /* 15 */ 1307674368000,
            /* 16 */ 20922789888000,
            /* 17 */ 355687428096000,
            /* 18 */ 6402373705728000,
            /* 19 */ 121645100408832000,
            /* 20 */ 2432902008176640000
        };
        public static long Fact(this IMathClause math, int n)
        {
            Bee.Guard.OutOfRange(n, 0, 20, $"{n} is too high to calculate fact");
            return _factValues[n];
        }

        private static readonly long[] _doubleFactValues =
        {
            /*  0 */ 1,
            /*  1 */ 1,
            /*  2 */ 2,
            /*  3 */ 3,
            /*  4 */ 8,
            /*  5 */ 15,
            /*  6 */ 48,
            /*  7 */ 105,
            /*  8 */ 384,
            /*  9 */ 945,
            /* 10 */ 3840,
            /* 11 */ 10395,
            /* 12 */ 46080,
            /* 13 */ 135135,
            /* 14 */ 645120,
            /* 15 */ 2027025,
            /* 16 */ 10321920,
            /* 17 */ 34459425,
            /* 18 */ 185794560,
            /* 19 */ 654729075,
            /* 20 */ 3715891200,
            /* 21 */ 13749310575,
            /* 22 */ 81749606400,
            /* 23 */ 316234143225,
            /* 24 */ 1961990553600,
            /* 25 */ 7905853580625,
            /* 26 */ 51011754393600,
            /* 27 */ 213458046676875,
            /* 28 */ 1428329123020800,
            /* 29 */ 6190283353629370,
            /* 30 */ 42849873690624000,
            /* 31 */ 191898783962511000,
            /* 32 */ 1371195958099970000,
            /* 33 */ 6332659870762850000,
        };
        public static long FactD(this IMathClause math, int n)
        {
            Bee.Guard.OutOfRange(n, 0, 33, $"{n} is too high to calculate double fact");
            return _doubleFactValues[n];
        }

    }
}