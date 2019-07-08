using System;
using ByteBee.Enums.Impl;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
namespace ByteBee.MathClause
{
    public static class FuncMathTrigonometric
    {
        /// <summary>
        /// sine (rad)
        /// </summary>
        public static double Sin(this IMathClause math, double theta)
        {
            return Math.Sin(theta);
        }

        /// <summary>
        /// cosine
        /// </summary>
        public static double Cos(this IMathClause math, double theta)
        {
            return Math.Cos(theta);
        }

        /// <summary>
        /// tangent (rad)
        /// </summary>
        public static double Tan(this IMathClause math, double theta)
        {
            return Math.Tan(theta);
        }

        /// <summary>
        /// cosecant (rad)
        /// </summary>
        public static double Csc(this IMathClause math, double theta)
        {
            return 1 / math.Sin(theta);
        }
        
        /// <summary>
        /// secant (rad)
        /// </summary>
        public static double Sec(this IMathClause math, double theta)
        {

            return 1 / math.Cos(theta);
        }
        
        /// <summary>
        /// cotangent (rad)
        /// </summary>
        public static double Cot(this IMathClause math, double theta)
        {
            return 1 / math.Tan(theta);
        }

        /// <summary>
        /// sine
        /// </summary>
        public static double Sin(this IMathClause math, double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return math.Sin(theta);
        }

        /// <summary>
        /// cosine
        /// </summary>
        public static double Cos(this IMathClause math, double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();

            return math.Cos(theta);
        }

        /// <summary>
        /// tangent
        /// </summary>
        public static double Tan(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Tan(theta * unit.ToRad());
        }

        /// <summary>
        /// cosecant
        /// </summary>
        public static double Csc(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Csc(theta * unit.ToRad());
        }

        /// <summary>
        /// secant
        /// </summary>
        public static double Sec(this IMathClause math, double theta, AngleUnit unit)
        {
            return math.Sec(theta * unit.ToRad());
        }

        /// <summary>
        /// cotangent
        /// </summary>
        public static double Cot(this IMathClause math, double x, AngleUnit unit)
        {
            return math.Cot(x * unit.ToRad());
        }
    }
}