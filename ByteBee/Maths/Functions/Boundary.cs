using System.Linq;

namespace ByteBee.Mathematics.Functions
{
    public partial interface IMathFunctions
    {
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        sbyte Max(sbyte a, sbyte b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        byte Max(byte a, byte b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        short Max(short a, short b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        ushort Max(ushort a, ushort b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        int Max(int a, int b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        uint Max(uint a, uint b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        long Max(long a, long b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        ulong Max(ulong a, ulong b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        float Max(float a, float b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        double Max(double a, double b);
        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        decimal Max(decimal a, decimal b);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        sbyte Max(sbyte a, sbyte b, sbyte c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        byte Max(byte a, byte b, byte c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        short Max(short a, short b, short c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        ushort Max(ushort a, ushort b, ushort c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        int Max(int a, int b, int c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        uint Max(uint a, uint b, uint c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        long Max(long a, long b, long c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        ulong Max(ulong a, ulong b, ulong c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        float Max(float a, float b, float c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        double Max(double a, double b, double c);
        /// <summary>
        /// Returns the larger of three numbers.
        /// </summary>
        decimal Max(decimal a, decimal b, decimal c);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        sbyte Max(sbyte a, sbyte b, params sbyte[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        byte Max(byte a, byte b, params byte[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        short Max(short a, short b, params short[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        ushort Max(ushort a, ushort b, params ushort[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        int Max(int a, int b, params int[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        uint Max(uint a, uint b, params uint[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        long Max(long a, long b, params long[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        ulong Max(ulong a, ulong b, params ulong[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        float Max(float a, float b, params float[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        double Max(double a, double b, params double[] p);
        /// <summary>
        /// Returns the larger of given numbers.
        /// </summary>
        decimal Max(decimal a, decimal b, params decimal[] p);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        sbyte Min(sbyte a, sbyte b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        byte Min(byte a, byte b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        short Min(short a, short b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        ushort Min(ushort a, ushort b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        int Min(int a, int b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        uint Min(uint a, uint b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        long Min(long a, long b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        ulong Min(ulong a, ulong b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        float Min(float a, float b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        double Min(double a, double b);
        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        decimal Min(decimal a, decimal b);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        sbyte Min(sbyte a, sbyte b, sbyte c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        byte Min(byte a, byte b, byte c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        short Min(short a, short b, short c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        ushort Min(ushort a, ushort b, ushort c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        int Min(int a, int b, int c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        uint Min(uint a, uint b, uint c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        long Min(long a, long b, long c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        ulong Min(ulong a, ulong b, ulong c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        float Min(float a, float b, float c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        double Min(double a, double b, double c);
        /// <summary>
        /// Returns the smaller of three numbers.
        /// </summary>
        decimal Min(decimal a, decimal b, decimal c);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        sbyte Min(sbyte a, sbyte b, params sbyte[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        byte Min(byte a, byte b, params byte[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        short Min(short a, short b, params short[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        ushort Min(ushort a, ushort b, params ushort[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        int Min(int a, int b, params int[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        uint Min(uint a, uint b, params uint[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        long Min(long a, long b, params long[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        ulong Min(ulong a, ulong b, params ulong[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        float Min(float a, float b, params float[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        double Min(double a, double b, params double[] p);
        /// <summary>
        /// Returns the smaller of given numbers.
        /// </summary>
        decimal Min(decimal a, decimal b, params decimal[] p);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        sbyte Clamp(sbyte val, sbyte min, sbyte max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        byte Clamp(byte val, byte min, byte max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        short Clamp(short val, short min, short max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        ushort Clamp(ushort val, ushort min, ushort max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        int Clamp(int val, int min, int max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        uint Clamp(uint val, uint min, uint max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        long Clamp(long val, long min, long max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        ulong Clamp(ulong val, ulong min, ulong max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        float Clamp(float val, float min, float max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        double Clamp(double val, double min, double max);
        /// <summary>
        /// Ensures, that a number is within a range and returns either the min or the max value.
        /// </summary>
        decimal Clamp(decimal val, decimal min, decimal max);
        /// <summary>
        /// Transform an angle into a range between -180° and 180°
        /// </summary>
        double ClampAngleDeg(double theta, double min, double max);
        /// <summary>
        /// Transform an angle into a range between -PI and PI
        /// </summary>
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