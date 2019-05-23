using System;
using System.Security.Cryptography;
using ByteBee.Enums.Impl;
using ByteBee.Extensions;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
namespace ByteBee.MathClause
{
    public static class FuncMathArcus
    {
        /// <summary>
        /// arcus sine (rad)
        /// </summary>
        public static double Asin(this IMathClause math, double theta)
        {
            return Math.Asin(theta);
        }

        /// <summary>
        /// arcus cosine (rad)
        /// </summary>
        public static double Acos(this IMathClause math, double theta)
        {
            return Math.Acos(theta);
        }

        /// <summary>
        /// arcus tangent (rad)
        /// </summary>
        public static double Atan(this IMathClause math, double theta)
        {
            return Math.Atan(theta);
        }

        /// <summary>
        /// arcus cosecant (rad)
        /// </summary>
        public static double Acsc(this IMathClause math, double theta)
        {
            return math.Atan(math.Sign(theta) / math.Sqrt(theta * theta - 1));
        }

        /// <summary>
        /// arcus secant (rad)
        /// </summary>
        public static double Asec(this IMathClause math, double theta)
        {
            return 2 * math.Atan(1) - math.Atan(math.Sign(theta) / math.Sqrt(theta * theta - 1));
        }

        /// <summary>
        /// arcus cotangent (rad)
        /// </summary>
        public static double Acot(this IMathClause math, double theta)
        {
            return 2 * math.Atan(1) - math.Atan(theta);
        }

        /// <summary>
        /// arcus sine
        /// </summary>
        public static double Asin(this IMathClause math, double theta, AngleUnit angle)
        {
            return math.Asin(theta) / angle.ToRad();
        }

        /// <summary>
        /// arcus cosine
        /// </summary>
        public static double Acos(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Acos(theta) / unit.ToRad();
        }

        /// <summary>
        /// arcus tangent
        /// </summary>
        public static double Atan(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Atan(theta) / unit.ToRad();
        }

        /// <summary>
        /// arcus cosecant
        /// </summary>
        public static double Acsc(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Acsc(theta) / unit.ToRad();
        }

        /// <summary>
        /// arcus secant
        /// </summary>
        public static double Asec(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Asec(theta) / unit.ToRad();
        }

        /// <summary>
        /// arcus cotangent
        /// </summary>
        public static double Acot(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Acot(theta)/ unit.ToRad();
        }
    }
}