// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace ByteBee.MathClause
{
    public static class FuncMathHyperbolic
    {
        /// <summary>
        /// Sinus hyperbolicus
        /// </summary>
        public static double Sinh(this IMathClause math, double x)
        {
            return System.Math.Sinh(x);
        }

        /// <summary>
        /// Kosinus hyperbolicus
        /// </summary>
        public static double Cosh(this IMathClause math, double x)
        {
            return System.Math.Cosh(x);
        }

        /// <summary>
        /// Tangens hyperbolicus
        /// </summary>
        public static double Tanh(this IMathClause math, double x)
        {
            return System.Math.Tanh(x);
        }

        /// <summary>
        /// Kotangens hyperbolicus
        /// </summary>
        public static double Coth(this IMathClause math, double x)
        {
            return (math.Exp(x) + math.Exp(-x)) / (math.Exp(x) - math.Exp(-x));
        }

        /// <summary>
        /// Sekans hyperbolicus
        /// </summary>
        public static double Sech(this IMathClause math, double x)
        {
            return 2 / (math.Exp(x) + math.Exp(x));
        }

        /// <summary>
        /// Kosekans hyperbolicus
        /// </summary>
        public static double Csch(this IMathClause math, double x)
        {
            return 2 / (math.Exp(x) - math.Exp(x));
        }
    }
}