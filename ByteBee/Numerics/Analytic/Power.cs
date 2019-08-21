using System;

namespace ByteBee.Numerics.Analytic
{
    public static class Power
    {
        public static double BaseE(double x)
        {
            return Math.Pow(x, MathConstant.Euler);
        }

        public static double Base2(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double Base3(double x)
        {
            return Math.Pow(x, 3);
        }

        public static double Base8(double x)
        {
            return Math.Pow(x, 8);
        }

        public static double Base10(double x)
        {
            return Math.Pow(x, 10);
        }

        public static double Base16(double x)
        {
            return Math.Pow(x, 16);
        }

        public static double BaseN(double x, double @base)
        {
            return Math.Pow(x, @base);
        }
    }
}