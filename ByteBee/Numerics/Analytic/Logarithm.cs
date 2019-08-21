using System;

namespace ByteBee.Numerics.Analytic
{
    public static class Logarithm
    {
        public static double BaseE(double d)
        {
            return Math.Log(d);
        }

        public static double Base2(double d)
        {
            return Math.Log(d, 2);
        }

        public static double Base3(double d)
        {
            return Math.Log(d, 2);
        }

        public static double Base8(double d)
        {
            return Math.Log(d, 8);
        }

        public static double Base10(double d)
        {
            return Math.Log(d, 10);
        }

        public static double Base16(double d)
        {
            return Math.Log(d, 16);
        }

        public static double BaseN(double a, double @base)
        {
            return Math.Log(a, @base);
        }
    }
}