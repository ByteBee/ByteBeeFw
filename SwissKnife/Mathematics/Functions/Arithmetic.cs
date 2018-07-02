using System;

namespace SwissKnife.Mathematics.Functions
{
    public partial interface IMathFunctions
    {
        decimal Ceiling(decimal d);
        double Ceiling(double a);

        decimal Floor(decimal d);
        double Floor(double d);

        double Round(double value);
        double Round(double value, int digits);
        double Round(double value, MidpointRounding mode);
        double Round(double value, int digits, MidpointRounding mode);
        decimal Round(decimal value);
        decimal Round(decimal value, int decimals);
        decimal Round(decimal value, MidpointRounding mode);
        decimal Round(decimal value, int decimals, MidpointRounding mode);

        double Round1(double value);
        double Round1(double value, MidpointRounding mode);
        decimal Round1(decimal value);
        decimal Round1(decimal value, MidpointRounding mode);

        double Round2(double value);
        double Round2(double value, MidpointRounding mode);
        decimal Round2(decimal value);
        decimal Round2(decimal value, MidpointRounding mode);

        double Round3(double value);
        double Round3(double value, MidpointRounding mode);
        decimal Round3(decimal value);
        decimal Round3(decimal value, MidpointRounding mode);

        sbyte Abs(sbyte value);
        short Abs(short value);
        int Abs(int value);
        long Abs(long value);
        float Abs(float value);
        double Abs(double value);
        decimal Abs(decimal value);

        int Sign(sbyte value);
        int Sign(short value);
        int Sign(int value);
        int Sign(long value);
        int Sign(float value);
        int Sign(double value);
        int Sign(decimal value);

        double Pow(double x, double @base);
        double Pow2(double x);
        double Pow8(double x);
        double Pow10(double x);
        double Pow16(double x);

        double LogE(double d);
        double Log2(double d);
        double Log10(double d);
        double Log(double a, double @base);
        double Exp(double d);
    }

    internal partial class MathFunctions : IMathFunctions
    {
        public decimal Ceiling(decimal d) => Math.Ceiling(d);
        public double Ceiling(double a) => Math.Ceiling(a);
        public decimal Floor(decimal d) => Math.Floor(d);
        public double Floor(double d) => Math.Floor(d);

        public double Round(double value) => Math.Round(value);
        public double Round(double value, int digits) => Math.Round(value, digits);
        public double Round(double value, MidpointRounding mode) => Math.Round(value, mode);
        public double Round(double value, int digits, MidpointRounding mode) => Math.Round(value, digits, mode);
        public decimal Round(decimal value) => Math.Round(value);
        public decimal Round(decimal value, int decimals) => Math.Round(value, decimals);
        public decimal Round(decimal value, MidpointRounding mode) => Math.Round(value, mode);
        public decimal Round(decimal value, int decimals, MidpointRounding mode) => Math.Round(value, decimals, mode);
        public double Round1(double value) => Math.Round(value, 1);
        public double Round1(double value, MidpointRounding mode) => Math.Round(value, 1, mode);
        public decimal Round1(decimal value) => Math.Round(value, 1);
        public decimal Round1(decimal value, MidpointRounding mode) => Math.Round(value, 1, mode);
        public double Round2(double value) => Math.Round(value, 2);
        public double Round2(double value, MidpointRounding mode) => Math.Round(value, 2, mode);
        public decimal Round2(decimal value) => Math.Round(value, 2);
        public decimal Round2(decimal value, MidpointRounding mode) => Math.Round(value, 2, mode);
        public double Round3(double value) => Math.Round(value, 3);
        public double Round3(double value, MidpointRounding mode) => Math.Round(value, 3, mode);
        public decimal Round3(decimal value) => Math.Round(value, 3);
        public decimal Round3(decimal value, MidpointRounding mode) => Math.Round(value, 3, mode);

        public sbyte Abs(sbyte value) => Math.Abs(value);
        public short Abs(short value) => Math.Abs(value);
        public int Abs(int value) => Math.Abs(value);
        public long Abs(long value) => Math.Abs(value);
        public float Abs(float value) => Math.Abs(value);
        public double Abs(double value) => Math.Abs(value);
        public decimal Abs(decimal value) => Math.Abs(value);

        public int Sign(sbyte value) => Math.Sign(value);
        public int Sign(short value) => Math.Sign(value);
        public int Sign(int value) => Math.Sign(value);
        public int Sign(long value) => Math.Sign(value);
        public int Sign(float value) => Math.Sign(value);
        public int Sign(double value) => Math.Sign(value);
        public int Sign(decimal value) => Math.Sign(value);

        public double LogE(double d) => Math.Log(d);
        public double Log2(double d) => Math.Log(d, 2);
        public double Log10(double d) => Math.Log10(d);
        public double Log(double a, double @base) => Math.Log(a, @base);
        public double Exp(double d) => Math.Exp(d);
        public double Pow(double x, double @base) => Math.Pow(x, @base);
        public double Pow2(double x) => Math.Pow(x, 2);
        public double Pow8(double x) => Math.Pow(x, 8);
        public double Pow10(double x) => Math.Pow(x, 10);
        public double Pow16(double x) => Math.Pow(x, 16);
    }
}