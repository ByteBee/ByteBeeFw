using System;
using static SwissKnife.Fancy;

namespace SwissKnife.Mathematics.Functions
{
    public interface ITrinogometryFunctions
    {
        /// <summary>
        /// Returns the sine of the specified angle (radiant).
        /// </summary>
        double Sin(double x);
        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        double Sin(double x, AngleUnit unit);
        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        double Cos(double x);
        double Cos(double x, AngleUnit unit);
        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        double Tan(double x);
        double Tan(double x, AngleUnit unit);
        /// <summary>
        /// Returns the cotangent of the specified angle.
        /// </summary>
        double Cot(double x);
        double Cot(double x, AngleUnit unit);
        /// <summary>
        /// Returns the secant of the specified angle.
        /// </summary>
        double Sec(double x);
        double Sec(double x, AngleUnit unit);
        /// <summary>
        /// Returns the cosecant of the specified angle.
        /// </summary>
        double Csc(double x);
        double Csc(double x, AngleUnit unit);

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        double Asin(double x);
        double Asin(double x, AngleUnit unit);
        /// <summary>
        /// Returns the angle whose cosine is the specified number
        /// </summary>
        double Acos(double x);
        double Acos(double x, AngleUnit unit);
        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        double Atan(double x);
        double Atan(double x, AngleUnit unit);
        /// <summary>
        /// Returns the angle whose cotangent is the specified number.
        /// </summary>
        double Acot(double x);
        double Acot(double x, AngleUnit unit);
        /// <summary>
        /// Returns the angle whose secant is the specified number.
        /// </summary>
        double Asec(double x);
        double Asec(double x, AngleUnit unit);
        /// <summary>
        /// Returns the angle whose cosecant is the specified number.
        /// </summary>
        double Acsc(double x);
        double Acsc(double x, AngleUnit unit);

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        double Sinh(double x);
        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        double Cosh(double x);
        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle
        /// </summary>
        double Tanh(double x);
        /// <summary>
        /// Returns the hyperbolic cotangent of the specified angle
        /// </summary>
        double Coth(double x);
        /// <summary>
        /// Returns the hyperbolic secant of the specified angle
        /// </summary>
        double Sech(double x);
        /// <summary>
        /// Returns the hyperbolic cosecant of the specified angle
        /// </summary>
        double Csch(double x);

        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions


        /// <summary>
        /// Returns the angle whose hyperbolic sine is the specified number.
        /// </summary>
        double Asinh(double x);
        /// <summary>
        /// Returns the angle whose hyperbolic cosine is the specified number
        /// </summary>
        double Acosh(double x);
        /// <summary>
        /// Returns the angle whose hyperbolic tangent is the specified number.
        /// </summary>
        double Atanh(double x);
        /// <summary>
        /// Returns the angle whose hyperbolic cotangent is the specified number.
        /// </summary>
        double Acoth(double x);
        /// <summary>
        /// Returns the angle whose hyperbolic secant is the specified number.
        /// </summary>
        double Asech(double x);
        /// <summary>
        /// Returns the angle whose hyperbolic cosecant is the specified number.
        /// </summary>
        double Acsch(double x);
    }

    internal partial class MathFunctions
    {
        public double Sin(double x) => Sin(x, AngleUnit.Rad);
        public double Sin(double x, AngleUnit unit) => Math.Sin(x * unit.ToRad());

        public double Cos(double x) => Cos(x, AngleUnit.Rad);
        public double Cos(double x, AngleUnit unit) => Math.Cos(x * unit.ToRad());

        public double Tan(double x) => Tan(x, AngleUnit.Rad);
        public double Tan(double x, AngleUnit unit)
        {
            if (Approx(x % 360, 90))
                return double.PositiveInfinity;

            if (math.Approx(x % 360, 270))
                return double.NegativeInfinity;

            return Math.Tan(x * unit.ToRad());
        }

        public double Csc(double x) => Csc(x, AngleUnit.Rad);
        public double Csc(double x, AngleUnit unit) => 1 / Sin(x, unit);

        public double Sec(double x) => Sec(x, AngleUnit.Rad);
        public double Sec(double x, AngleUnit unit) => 1 / Cos(x, unit);

        public double Cot(double x) => Cot(x, AngleUnit.Rad);
        public double Cot(double x, AngleUnit unit) => 1 / Tan(x, unit);


        public double Asin(double x) => Asin(x, AngleUnit.Rad);
        public double Asin(double x, AngleUnit unit) => Math.Asin(x) / unit.ToRad();

        public double Acos(double x) => Acos(x, AngleUnit.Rad);
        public double Acos(double x, AngleUnit unit) => Math.Acos(x) / unit.ToRad();

        public double Atan(double x) => Atan(x, AngleUnit.Rad);
        public double Atan(double x, AngleUnit unit) => Math.Atan(x) / unit.ToRad();

        public double Acsc(double x) => Acsc(x, AngleUnit.Rad);
        public double Acsc(double x, AngleUnit unit) => Atan(Sign(x) / Sqrt(x * x - 1)) / unit.ToRad();

        public double Asec(double x) => Asec(x, AngleUnit.Rad);
        public double Asec(double x, AngleUnit unit) => 2 * Atan(1) - Atan(Sign(x) / Sqrt(x * x - 1));

        public double Acot(double x) => Acot(x, AngleUnit.Rad);
        public double Acot(double x, AngleUnit unit) => 2 * Atan(1) - Atan(x);

        public double Sinh(double x) => Math.Sinh(x);
        public double Cosh(double x) => Math.Cosh(x);
        public double Tanh(double x) => Math.Tanh(x);
        public double Coth(double x) => (Exp(x) + Exp(-x)) / (Exp(x) - Exp(-x));
        public double Sech(double x) => 2 / (Exp(x) + Exp(x));
        public double Csch(double x) => 2 / (Exp(x) - Exp(x));

        public double Asinh(double x) => LogE(x + Sqrt(x * x + 1));
        public double Acosh(double x) => LogE(x + Sqrt(x * x - 1));
        public double Atanh(double x) => LogE((1 + x) / (1 - x)) / 2;
        public double Acoth(double x) => LogE((x + 1) / (x - 1)) / 2;
        public double Asech(double x) => LogE((Sqrt(-x * x + 1) + 1) / x);
        public double Acsch(double x) => LogE((Sign(x) * Sqrt(x * x + 1) + 1) / x);
    }
}