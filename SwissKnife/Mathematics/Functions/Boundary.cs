using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissKnife.Mathematics.Functions
{
    public partial interface IMathFunctions
    {
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

        sbyte Max(sbyte a, sbyte b, params sbyte[] p);
        byte Max(byte a, byte b, params byte[] p);
        short Max(short a, short b, params short[] p);
        ushort Max(ushort a, ushort b, params ushort[] p);
        int Max(int a, int b, params int[] p);
        uint Max(uint a, uint b, params uint[] p);
        long Max(long a, long b, params long[] p);
        ulong Max(ulong a, ulong b, params ulong[] p);
        float Max(float a, float b, params float[] p);
        double Max(double a, double b, params double[] p);
        decimal Max(decimal a, decimal b, params decimal[] p);

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

        sbyte Min(sbyte a, sbyte b, params sbyte[] p);
        byte Min(byte a, byte b, params byte[] p);
        short Min(short a, short b, params short[] p);
        ushort Min(ushort a, ushort b, params ushort[] p);
        int Min(int a, int b, params int[] p);
        uint Min(uint a, uint b, params uint[] p);
        long Min(long a, long b, params long[] p);
        ulong Min(ulong a, ulong b, params ulong[] p);
        float Min(float a, float b, params float[] p);
        double Min(double a, double b, params double[] p);
        decimal Min(decimal a, decimal b, params decimal[] p);

        sbyte Clamp(sbyte val, sbyte min, sbyte max);
        byte Clamp(byte val, byte min, byte max);
        short Clamp(short val, short min, short max);
        ushort Clamp(ushort val, ushort min, ushort max);
        int Clamp(int val, int min, int max);
        uint Clamp(uint val, uint min, uint max);
        long Clamp(long val, long min, long max);
        ulong Clamp(ulong val, ulong min, ulong max);
        float Clamp(float val, float min, float max);
        double Clamp(double val, double min, double max);
        decimal Clamp(decimal val, decimal min, decimal max);

        double ClampAngleDeg(double theta, double min, double max);
        double ClampAngleRad(double theta, double min, double max);
    }

    internal partial class MathFunctions : IMathFunctions
    {
        public sbyte Max(sbyte a, sbyte b) => a > b ? a : b;
        public byte Max(byte a, byte b) => a > b ? a : b;
        public short Max(short a, short b) => a > b ? a : b;
        public ushort Max(ushort a, ushort b) => a > b ? a : b;
        public int Max(int a, int b) => a > b ? a : b;
        public uint Max(uint a, uint b) => a > b ? a : b;
        public long Max(long a, long b) => a > b ? a : b;
        public ulong Max(ulong a, ulong b) => a > b ? a : b;
        public float Max(float a, float b) => a > b ? a : b;
        public double Max(double a, double b) => a > b ? a : b;
        public decimal Max(decimal a, decimal b) => a > b ? a : b;

        public sbyte Max(sbyte a, sbyte b, sbyte c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public byte Max(byte a, byte b, byte c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public short Max(short a, short b, short c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public ushort Max(ushort a, ushort b, ushort c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public ulong Max(ulong a, ulong b, ulong c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public float Max(float a, float b, float c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public int Max(int a, int b, int c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public uint Max(uint a, uint b, uint c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public long Max(long a, long b, long c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public double Max(double a, double b, double c) => a > b ? (a > c ? a : c) : (b > c ? b : c);
        public decimal Max(decimal a, decimal b, decimal c) => a > b ? (a > c ? a : c) : (b > c ? b : c);

        public sbyte Max(sbyte a, sbyte b, params sbyte[] p) => p.Aggregate(Max(a, b), Max);
        public byte Max(byte a, byte b, params byte[] p) => p.Aggregate(Max(a, b), Max);
        public short Max(short a, short b, params short[] p) => p.Aggregate(Max(a, b), Max);
        public ushort Max(ushort a, ushort b, params ushort[] p) => p.Aggregate(Max(a, b), Max);
        public int Max(int a, int b, params int[] p) => p.Aggregate(Max(a, b), Max);
        public uint Max(uint a, uint b, params uint[] p) => p.Aggregate(Max(a, b), Max);
        public long Max(long a, long b, params long[] p) => p.Aggregate(Max(a, b), Max);
        public ulong Max(ulong a, ulong b, params ulong[] p) => p.Aggregate(Max(a, b), Max);
        public float Max(float a, float b, params float[] p) => p.Aggregate(Max(a, b), Max);
        public double Max(double a, double b, params double[] p) => p.Aggregate(Max(a, b), Max);
        public decimal Max(decimal a, decimal b, params decimal[] p) => p.Aggregate(Max(a, b), Max);

        public sbyte Min(sbyte a, sbyte b) => a < b ? a : b;
        public byte Min(byte a, byte b) => a < b ? a : b;
        public short Min(short a, short b) => a < b ? a : b;
        public ushort Min(ushort a, ushort b) => a < b ? a : b;
        public int Min(int a, int b) => a < b ? a : b;
        public uint Min(uint a, uint b) => a < b ? a : b;
        public long Min(long a, long b) => a < b ? a : b;
        public ulong Min(ulong a, ulong b) => a < b ? a : b;
        public float Min(float a, float b) => a < b ? a : b;
        public double Min(double a, double b) => a < b ? a : b;
        public decimal Min(decimal a, decimal b) => a < b ? a : b;

        public ulong Min(ulong a, ulong b, ulong c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public float Min(float a, float b, float c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public ushort Min(ushort a, ushort b, ushort c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public int Min(int a, int b, int c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public uint Min(uint a, uint b, uint c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public long Min(long a, long b, long c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public sbyte Min(sbyte a, sbyte b, sbyte c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public byte Min(byte a, byte b, byte c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public short Min(short a, short b, short c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public double Min(double a, double b, double c) => a < b ? (a < c ? a : c) : (b < c ? b : c);
        public decimal Min(decimal a, decimal b, decimal c) => a < b ? (a < c ? a : c) : (b < c ? b : c);

        public sbyte Min(sbyte a, sbyte b, params sbyte[] p) => p.Aggregate(Min(a, b), Min);
        public byte Min(byte a, byte b, params byte[] p) => p.Aggregate(Min(a, b), Min);
        public short Min(short a, short b, params short[] p) => p.Aggregate(Min(a, b), Min);
        public ushort Min(ushort a, ushort b, params ushort[] p) => p.Aggregate(Min(a, b), Min);
        public int Min(int a, int b, params int[] p) => p.Aggregate(Min(a, b), Min);
        public uint Min(uint a, uint b, params uint[] p) => p.Aggregate(Min(a, b), Min);
        public long Min(long a, long b, params long[] p) => p.Aggregate(Min(a, b), Min);
        public ulong Min(ulong a, ulong b, params ulong[] p) => p.Aggregate(Min(a, b), Min);
        public float Min(float a, float b, params float[] p) => p.Aggregate(Min(a, b), Min);
        public double Min(double a, double b, params double[] p) => p.Aggregate(Min(a, b), Min);
        public decimal Min(decimal a, decimal b, params decimal[] p) => p.Aggregate(Min(a, b), Min);

        public sbyte Clamp(sbyte val, sbyte min, sbyte max) => val < min ? min : val > max ? max : val;
        public byte Clamp(byte val, byte min, byte max) => val < min ? min : val > max ? max : val;
        public short Clamp(short val, short min, short max) => val < min ? min : val > max ? max : val;
        public ushort Clamp(ushort val, ushort min, ushort max) => val < min ? min : val > max ? max : val;
        public int Clamp(int val, int min, int max) => val < min ? min : val > max ? max : val;
        public uint Clamp(uint val, uint min, uint max) => val < min ? min : val > max ? max : val;
        public long Clamp(long val, long min, long max) => val < min ? min : val > max ? max : val;
        public ulong Clamp(ulong val, ulong min, ulong max) => val < min ? min : val > max ? max : val;
        public float Clamp(float val, float min, float max) => val < min ? min : val > max ? max : val;
        public double Clamp(double val, double min, double max) => val < min ? min : val > max ? max : val;
        public decimal Clamp(decimal val, decimal min, decimal max) => val < min ? min : val > max ? max : val;

        public double ClampAngleDeg(double theta, double min, double max)
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

        public double ClampAngleRad(double theta, double min, double max)
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
    }
}