using System;

namespace ByteBee.Numerics
{
    public static class MathLogarithm
    {
        public static double BaseE(double d)
        {
            return Math.Log(d);
        }

        public static double Base2(double d)
        {
            return BaseN(d, 2);
        }

        public static double Base3(double d)
        {
            return BaseN(d, 3);
        }

        public static double Base8(double d)
        {
            return BaseN(d, 8);
        }

        public static double Base10(double d)
        {
            return BaseN(d, 10);
        }

        public static double Base16(double d)
        {
            return BaseN(d, 16);
        }

        public static double BaseN(double a, double @base)
        {
            return Math.Log(a, @base);
        }
    }
}