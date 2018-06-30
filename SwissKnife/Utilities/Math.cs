using System;

namespace SwissKnife.Utilities
{
    public interface IMath
    {
        double E { get; }
        double Epsilon { get; }
        double ZeroTolerance { get; }
        double Deg2Rad { get; }
        double Rad2Deg { get; }
        double Pi { get; }
        double Pi2 { get; }
        double Pi4 { get; }
        double PiHalf { get; }
        double Sqrt2 { get; }
        double Sqrt3 { get; }

        double Acos(double d);
        double Asin(double d);
        double Atan(double d);
        double Atan2(double y, double x);
        decimal Ceiling(decimal d);
        double Ceiling(double a);
        double Cos(double d);
        double Cosh(double value);
        decimal Floor(decimal d);
        double Floor(double d);
        double Sin(double a);
        double Tan(double a);
        double Sinh(double value);
        double Tanh(double value);
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
        decimal Truncate(decimal d);
        double Truncate(double d);
        double LogE(double d);
        double Log2(double d);
        double Log10(double d);
        double Log(double a, double @base);
        double Exp(double d);
        double Pow(double x, double @base);
        double Pow2(double x);
        double Pow8(double x);
        double Pow10(double x);
        double Pow16(double x);
        double IeeeRemainder(double x, double y);
        sbyte Abs(sbyte value);
        short Abs(short value);
        int Abs(int value);
        long Abs(long value);
        float Abs(float value);
        double Abs(double value);
        decimal Abs(decimal value);
        sbyte Max(sbyte a, sbyte b);
        byte Max(byte a, byte b);
        short Max(short a, short b);
        ushort Max(ushort a, ushort b);
        int Max(int a, int b);
        uint Max(uint a, uint b);
        long Max(long a, long b);
        ulong Max(ulong a, ulong b);
        float Max(float a, float b);
        double Max(double a, double b);
        decimal Max(decimal a, decimal b);
        sbyte Max(sbyte a, sbyte b, sbyte c);
        byte Max(byte a, byte b, byte c);
        short Max(short a, short b, short c);
        ushort Max(ushort a, ushort b, ushort c);
        int Max(int a, int b, int c);
        uint Max(uint a, uint b, uint c);
        long Max(long a, long b, long c);
        ulong Max(ulong a, ulong b, ulong c);
        float Max(float a, float b, float c);
        double Max(double a, double b, double c);
        decimal Max(decimal a, decimal b, decimal c);
        sbyte Min(sbyte a, sbyte b);
        byte Min(byte a, byte b);
        short Min(short a, short b);
        ushort Min(ushort a, ushort b);
        int Min(int a, int b);
        uint Min(uint a, uint b);
        long Min(long a, long b);
        ulong Min(ulong a, ulong b);
        float Min(float a, float b);
        double Min(double a, double b);
        decimal Min(decimal a, decimal b);
        sbyte Min(sbyte a, sbyte b, sbyte c);
        byte Min(byte a, byte b, byte c);
        short Min(short a, short b, short c);
        ushort Min(ushort a, ushort b, ushort c);
        int Min(int a, int b, int c);
        uint Min(uint a, uint b, uint c);
        long Min(long a, long b, long c);
        ulong Min(ulong a, ulong b, ulong c);
        float Min(float a, float b, float c);
        double Min(double a, double b, double c);
        decimal Min(decimal a, decimal b, decimal c);
        int Sign(sbyte value);
        int Sign(short value);
        int Sign(int value);
        int Sign(long value);
        int Sign(float value);
        int Sign(double value);
        int Sign(decimal value);
        long BigMul(int a, int b);
        int DivRem(int a, int b, out int result);
        long DivRem(long a, long b, out long result);
        double Sqrt(double d);
        bool IsFinite(double d);
        bool IsFinite(float d);
        T Bound<T>(T f, T low, T high) where T : IComparable;
        float Bound(float f, float low, float high);
        double Bound(double f, double low, double high);
        int Bound(int f, int low, int high);
        bool IsBetween(float value, float low, float high);
        bool IsBetween(double value, double low, double high);
        bool IsBetween(int value, int low, int high);
        double BoundAngleDeg(double theta, double min, double max);
        double BoundAngleRad(double theta, double min, double max);
        double InvSqrt(double f);
        bool EpsilonEqual(double a, double b);
        bool EpsilonEqual(double a, double b, double epsilon);
    }

    public abstract class MathAdapter : IMath
    {
        public double E { get; } = Math.E;
        public double Epsilon { get; } = 2.2204460492503131e-016;
        public double ZeroTolerance { get; } = 1E-08;
        public double Deg2Rad { get; } = Math.PI / 180;
        public double Rad2Deg { get; } = 180 / Math.PI;
        public double Pi { get; } = Math.PI;
        public double Pi2 { get; } = Math.PI * 2;
        public double Pi4 { get; } = Math.PI * 4;
        public double PiHalf { get; } = Math.PI * 0.5;
        public double Sqrt2 { get; } = 1.41421356237309504880168872420969807;
        public double Sqrt3 { get; } = 1.73205080756887729352744634150587236;
        public double Acos(double d) => Math.Acos(d);
        public double Asin(double d) => Math.Asin(d);
        public double Atan(double d) => Math.Atan(d);
        public double Atan2(double y, double x) => Math.Atan2(y, x);
        public decimal Ceiling(decimal d) => Math.Ceiling(d);
        public double Ceiling(double a) => Math.Ceiling(a);
        public double Cos(double d) => Math.Cos(d);
        public double Cosh(double value) => Math.Cosh(value);
        public decimal Floor(decimal d) => Math.Floor(d);
        public double Floor(double d) => Math.Floor(d);
        public double Sin(double a) => Math.Sin(a);
        public double Tan(double a) => Math.Tan(a);
        public double Sinh(double value) => Math.Sinh(value);
        public double Tanh(double value) => Math.Tanh(value);
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
        public decimal Truncate(decimal d) => Math.Truncate(d);
        public double Truncate(double d) => Math.Truncate(d);
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
        public double IeeeRemainder(double x, double y) => Math.IEEERemainder(x, y);
        public sbyte Abs(sbyte value) => Math.Abs(value);
        public short Abs(short value) => Math.Abs(value);
        public int Abs(int value) => Math.Abs(value);
        public long Abs(long value) => Math.Abs(value);
        public float Abs(float value) => Math.Abs(value);
        public double Abs(double value) => Math.Abs(value);
        public decimal Abs(decimal value) => Math.Abs(value);
        public sbyte Max(sbyte a, sbyte b) => Math.Max(a, b);

        public byte Max(byte a, byte b) => Math.Max(a, b);
        public short Max(short a, short b) => Math.Max(a, b);
        public ushort Max(ushort a, ushort b) => Math.Max(a, b);
        public int Max(int a, int b) => Math.Max(a, b);
        public uint Max(uint a, uint b) => Math.Max(a, b);
        public long Max(long a, long b) => Math.Max(a, b);
        public ulong Max(ulong a, ulong b) => Math.Max(a, b);
        public float Max(float a, float b) => Math.Max(a, b);
        public double Max(double a, double b) => Math.Max(a, b);
        public decimal Max(decimal a, decimal b) => Math.Max(a, b);

        public sbyte Max(sbyte a, sbyte b, sbyte c) => Math.Max(Math.Max(a, b), c);
        public byte Max(byte a, byte b, byte c) => Math.Max(Math.Max(a, b), c);
        public short Max(short a, short b, short c) => Math.Max(Math.Max(a, b), c);
        public ushort Max(ushort a, ushort b, ushort c) => Math.Max(Math.Max(a, b), c);
        public long DivRem(long a, long b, out long result) => Math.DivRem(a, b, out result);
        public double Sqrt(double d) => Math.Sqrt(d);
        public bool IsFinite(double d) => double.IsInfinity(d) == false && double.IsNaN(d) == false;
        public bool IsFinite(float d) => float.IsInfinity(d) == false && float.IsNaN(d) == false;
        public bool EpsilonEqual(double a, double b) => EpsilonEqual(a, b, Epsilon);
        public bool EpsilonEqual(double a, double b, double epsilon) => Math.Abs(a - b) <= epsilon;
        public T Bound<T>(T f, T low, T high) where T : IComparable
            => f.CompareTo(low) < 0 ? low : (f.CompareTo(high) > 0 ? high : f);
        public float Bound(float f, float low, float high) => f < low ? low : f > high ? high : f;
        public double Bound(double f, double low, double high) => f < low ? low : f > high ? high : f;
        public int Bound(int f, int low, int high) => f < low ? low : f > high ? high : f;
        public bool IsBetween(float value, float low, float high) => value >= low && value <= high;
        public bool IsBetween(double value, double low, double high) => value >= low && value <= high;
        public bool IsBetween(int value, int low, int high) => value >= low && value <= high;

        public double BoundAngleDeg(double theta, double min, double max)
        {
            // convert interval to center/extent - [c-e,c+e]
            double c = (min + max) * 0.5;
            double e = max - c;

            // get rid of extra rotations
            theta = theta % 360;

            // shift to origin, then convert theta to +- 180
            theta -= c;
            if (theta < -180)
                theta += 360;
            else if (theta > 180)
                theta -= 360;

            // clamp to extent
            if (theta < -e)
                theta = -e;
            else if (theta > e)
                theta = e;

            // shift back
            return theta + c;
        }

        public double BoundAngleRad(double theta, double min, double max)
        {
            // convert interval to center/extent - [c-e,c+e]
            double c = (min + max) * 0.5;
            double e = max - c;

            // get rid of extra rotations
            theta = theta % Pi2;

            // shift to origin, then convert theta to +- 180
            theta -= c;
            if (theta < -Pi)
                theta += Pi2;
            else if (theta > Pi)
                theta -= Pi2;

            // clamp to extent
            if (theta < -e)
                theta = -e;
            else if (theta > e)
                theta = e;

            // shift back
            return theta + c;
        }

        public double Min(double a, double b, double c) => Math.Min(a, Math.Min(b, c));
        public decimal Min(decimal a, decimal b, decimal c) => Math.Min(a, Math.Min(b, c));
        public int Sign(sbyte value) => Math.Sign(value);
        public int Sign(short value) => Math.Sign(value);
        public int Sign(int value) => Math.Sign(value);
        public int Sign(long value) => Math.Sign(value);
        public int Sign(float value) => Math.Sign(value);
        public int Sign(double value) => Math.Sign(value);
        public int Sign(decimal value) => Math.Sign(value);
        public long BigMul(int a, int b) => Math.BigMul(a, b);
        public int DivRem(int a, int b, out int result) => Math.DivRem(a, b, out result);
        public ulong Min(ulong a, ulong b, ulong c) => Math.Min(a, Math.Min(b, c));
        public float Min(float a, float b, float c) => Math.Min(a, Math.Min(b, c));
        public ushort Min(ushort a, ushort b, ushort c) => Math.Min(a, Math.Min(b, c));
        public int Min(int a, int b, int c) => Math.Min(a, Math.Min(b, c));
        public uint Min(uint a, uint b, uint c) => Math.Min(a, Math.Min(b, c));
        public long Min(long a, long b, long c) => Math.Min(a, Math.Min(b, c));
        public double Max(double a, double b, double c) => Math.Max(a, Math.Max(b, c));
        public decimal Max(decimal a, decimal b, decimal c) => Math.Max(Math.Max(a, b), c);
        public sbyte Min(sbyte a, sbyte b) => Math.Min(a, b);
        public byte Min(byte a, byte b) => Math.Min(a, b);
        public short Min(short a, short b) => Math.Min(a, b);
        public ushort Min(ushort a, ushort b) => Math.Min(a, b);
        public int Min(int a, int b) => Math.Min(a, b);
        public uint Min(uint a, uint b) => Math.Min(a, b);
        public long Min(long a, long b) => Math.Min(a, b);
        public ulong Min(ulong a, ulong b) => Math.Min(a, b);
        public float Min(float a, float b) => Math.Min(a, b);
        public double Min(double a, double b) => Math.Min(a, b);
        public decimal Min(decimal a, decimal b) => Math.Min(a, b);
        public sbyte Min(sbyte a, sbyte b, sbyte c) => Math.Min(Math.Min(a, b), c);
        public byte Min(byte a, byte b, byte c) => Math.Min(Math.Min(a, b), c);
        public short Min(short a, short b, short c) => Math.Min(Math.Min(a, b), c);
        public ulong Max(ulong a, ulong b, ulong c) => Math.Max(Math.Max(a, b), c);
        public float Max(float a, float b, float c) => Math.Max(a, Math.Max(b, c));
        public int Max(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
        public uint Max(uint a, uint b, uint c) => Math.Max(Math.Max(a, b), c);
        public long Max(long a, long b, long c) => Math.Max(Math.Max(a, b), c);
        public double InvSqrt(double f) => f / Math.Sqrt(f);
    }

    internal class MathImpl : MathAdapter { }
}