using System;
using static SwissKnife.Fancy;

namespace SwissKnife.Mathematics.Functions
{
    public interface ITrinogometryFunctions
    {
        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        double Sin(double tetha);
        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        double Cos(double tetha);
        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        double Tan(double tetha);
        /// <summary>
        /// Returns the cotangent of the specified angle.
        /// </summary>
        double Cot(double tetha);
        /// <summary>
        /// Returns the secant of the specified angle.
        /// </summary>
        double Sec(double tetha);
        /// <summary>
        /// Returns the cosecant of the specified angle.
        /// </summary>
        double Csc(double tetha);

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        double Asin(double angle);
        /// <summary>
        /// Returns the angle whose cosine is the specified number
        /// </summary>
        double Acos(double angle);
        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        double Atan(double angle);
        /// <summary>
        /// Returns the angle whose cotangent is the specified number.
        /// </summary>
        double Acot(double angle);
        /// <summary>
        /// Returns the angle whose secant is the specified number.
        /// </summary>
        double Asec(double angle);
        /// <summary>
        /// Returns the angle whose cosecant is the specified number.
        /// </summary>
        double Acsc(double angle);

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        double Sinh(double tetha);
        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        double Cosh(double tetha);
        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle
        /// </summary>
        double Tanh(double tetha);
        /// <summary>
        /// Returns the hyperbolic cotangent of the specified angle
        /// </summary>
        double Coth(double tetha);
        /// <summary>
        /// Returns the hyperbolic secant of the specified angle
        /// </summary>
        double Sech(double tetha);
        /// <summary>
        /// Returns the hyperbolic cosecant of the specified angle
        /// </summary>
        double Csch(double tetha);

        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions


        /// <summary>
        /// Returns the angle whose hyperbolic sine is the specified number.
        /// </summary>
        double Asinh(double angle);
        /// <summary>
        /// Returns the angle whose hyperbolic cosine is the specified number
        /// </summary>
        double Acosh(double angle);
        /// <summary>
        /// Returns the angle whose hyperbolic tangent is the specified number.
        /// </summary>
        double Atanh(double angle);
        /// <summary>
        /// Returns the angle whose hyperbolic cotangent is the specified number.
        /// </summary>
        double Acoth(double angle);
        /// <summary>
        /// Returns the angle whose hyperbolic secant is the specified number.
        /// </summary>
        double Asech(double angle);
        /// <summary>
        /// Returns the angle whose hyperbolic cosecant is the specified number.
        /// </summary>
        double Acsch(double angle);
    }

    internal class TrinogometryFunctions : ITrinogometryFunctions
    {
        private double _deg2radFactor;

        public TrinogometryFunctions(double deg2RadFactor)
        {
            _deg2radFactor = deg2RadFactor;
        }

        public double Sin(double tetha) => Math.Sin(tetha * _deg2radFactor);
        public double Cos(double tetha) => Math.Cos(tetha * _deg2radFactor);
        public double Tan(double tetha)
        {
            if (math.Approx(tetha % 360, 90))
                return double.PositiveInfinity;

            if (math.Approx(tetha % 360, 270))
                return double.NegativeInfinity;

            return Math.Tan(tetha * _deg2radFactor);
        }

        public double Csc(double tetha) => 1 / Sin(tetha);
        public double Sec(double tetha) => 1 / Cos(tetha);
        public double Cot(double tetha) => 1 / Tan(tetha);

        public double Asin(double angle) => Math.Asin(angle) / _deg2radFactor;
        public double Acos(double angle) => Math.Acos(angle) / _deg2radFactor;
        public double Atan(double angle) => Math.Atan(angle) / _deg2radFactor;
        public double Acsc(double angle) => 1 / Asin(angle * _deg2radFactor);
        public double Asec(double angle) => 1 / Cos(angle * _deg2radFactor);
        public double Acot(double angle) => 1 / Atan(angle * _deg2radFactor);

        public double Sinh(double tetha) => Math.Sinh(tetha * _deg2radFactor);
        public double Cosh(double tetha) => Math.Cosh(tetha * _deg2radFactor);
        public double Tanh(double tetha) => Math.Tanh(tetha * _deg2radFactor);
        public double Coth(double tetha) => 1 / Tanh(tetha * _deg2radFactor);
        public double Sech(double tetha) => 1 / Cosh(tetha * math.Rad2Deg);
        public double Csch(double tetha) => 1 / Sinh(tetha * _deg2radFactor);

        public double Asinh(double angle) => Math.Pow(Sinh(angle * _deg2radFactor), -1);
        public double Acosh(double angle) => Math.Pow(Cosh(angle * _deg2radFactor), -1);
        public double Atanh(double angle) => Math.Pow(Tanh(angle * _deg2radFactor), -1);
        public double Acoth(double angle) => Math.Pow(Coth(angle * _deg2radFactor), -1);
        public double Asech(double angle) => Math.Pow(Sech(angle * _deg2radFactor), -1);
        public double Acsch(double angle) => Math.Pow(Csch(angle * _deg2radFactor), -1);
    }
}