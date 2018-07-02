using System;

namespace SwissKnife.Mathematics.Functions
{
    public partial interface IMathFunctions
    {
        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified decimal number.
        /// </summary>
        decimal Ceiling(decimal d);
        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified decimal number.
        /// </summary>
        double Ceiling(double a);
        /// <summary>
        /// Returns the largest integer less than or equal to the specified decimal number.
        /// </summary>
        decimal Floor(decimal d);
        /// <summary>
        /// Returns the largest integer less than or equal to the specified decimal number.
        /// </summary>
        double Floor(double d);
        /// <summary>
        /// Rounds a number value to the nearest integral value.
        /// </summary>
        double Round(double value);
        /// <summary>
        /// Rounds a value to a specified number of fractional digits.
        /// </summary>
        double Round(double value, int digits);
        /// <summary>
        /// Rounds a value to the nearest integer. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        double Round(double value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to a specified number of fractional digits. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        double Round(double value, int digits, MidpointRounding mode);
        /// <summary>
        /// Rounds a number value to the nearest integral value.
        /// </summary>
        decimal Round(decimal value);
        /// <summary>
        /// Rounds a value to a specified number of fractional digits.
        /// </summary>
        decimal Round(decimal value, int decimals);
        /// <summary>
        /// Rounds a value to the nearest integral value. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        decimal Round(decimal value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to a specified number of fractional digits. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        decimal Round(decimal value, int decimals, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to one significant digit.
        /// </summary>
        double Round1(double value);
        /// <summary>
        /// Rounds a value to one significant digit. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        double Round1(double value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to one significant digit.
        /// </summary>
        decimal Round1(decimal value);
        /// <summary>
        /// Rounds a value to one significant digit. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        decimal Round1(decimal value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to two significant digits.
        /// </summary>
        double Round2(double value);
        /// <summary>
        /// Rounds a value to one significant digit. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        double Round2(double value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to two significant digits.
        /// </summary>
        decimal Round2(decimal value);
        /// <summary>
        /// Rounds a value to one significant digit. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        decimal Round2(decimal value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to three significant digits.
        /// </summary>
        double Round3(double value);
        /// <summary>
        /// Rounds a value to one significant digit. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        double Round3(double value, MidpointRounding mode);
        /// <summary>
        /// Rounds a value to three significant digits.
        /// </summary>
        decimal Round3(decimal value);
        /// <summary>
        /// Rounds a value to one significant digit. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        decimal Round3(decimal value, MidpointRounding mode);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        sbyte Abs(sbyte value);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        short Abs(short value);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        int Abs(int value);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        long Abs(long value);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        float Abs(float value);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        double Abs(double value);
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        decimal Abs(decimal value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number.  -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(sbyte value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number. -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(short value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number. -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(int value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number. -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(long value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number. -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(float value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number. -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(double value);
        /// <summary>
        /// Returns an integer that indicates the sign of a number. -1 for negatives, +1 for positives, 0 for 0
        /// </summary>
        int Sign(decimal value);
        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        double Pow(double x, double @base);
        /// <summary>
        /// Returns a specified number raised to the power of 2 (binary).
        /// </summary>
        double Pow2(double x);
        /// <summary>
        /// Returns a specified number raised to the power of 8 (octal).
        /// </summary>
        double Pow8(double x);
        /// <summary>
        /// Returns a specified number raised to the power of 10 (decimal).
        /// </summary>
        double Pow10(double x);
        /// <summary>
        /// Returns a specified number raised to the power of 16 (hexadecimal).
        /// </summary>
        double Pow16(double x);

        /// <summary>
        /// Returns the natural (base e) logarithm of a specified number.
        /// </summary>
        double LogE(double d);
        /// <summary>
        /// Returns the binary (base 2) logarithm of a specified number.
        /// </summary>
        double Log2(double d);
        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        double Log10(double d);
        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        double Log(double a, double @base);
        /// <summary>
        /// Returns <b>e</b> raised to the specified power.
        /// </summary>
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