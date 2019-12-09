using System;

namespace ByteBee.Numerics
{
    public static class MathRound
    {
        public static double SigDigN(double value, int digits)
        {
            return Math.Round(value, digits);
        }

        public static decimal SigDigN(decimal value, int digits)
        {
            return Math.Round(value, digits);
        }

        public static double SigDig1(double value)
        {
            return SigDigN(value, 1);
        }

        public static decimal SigDig1(decimal value)
        {
            return SigDigN(value, 1);
        }

        public static double SigDig2(double value)
        {
            return SigDigN(value, 2);
        }

        public static decimal SigDig2(decimal value)
        {
            return SigDigN(value, 2);
        }

        public static double SigDig3(double value)
        {
            return SigDigN(value, 3);
        }

        public static decimal SigDig3(decimal value)
        {
            return SigDigN(value, 3);
        }
    }
}