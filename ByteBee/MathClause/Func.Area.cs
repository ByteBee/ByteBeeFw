// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
namespace ByteBee.MathClause
{
    public static class FuncMathHyperbolicInverse
    {
        /// <summary>
        /// areasinus hyperbolicus
        /// </summary>
        public static double Asinh(this IMathClause math, double x)
        {
            return math.LogE(x + math.Sqrt(x * x + 1));
        }

        /// <summary>
        /// areakosinus hyperbolicus
        /// </summary>
        public static double Acosh(this IMathClause math, double x)
        {
            return math.LogE(x + math.Sqrt(x * x - 1));
        }

        /// <summary>
        /// areatangens hyperbolicus
        /// </summary>
        public static double Atanh(this IMathClause math, double x)
        {
            return math.LogE((1 + x) / (1 - x)) / 2;
        }

        /// <summary>
        /// areakotangens hyperbolicus
        /// </summary>
        public static double Acoth(this IMathClause math, double x)
        {
            return math.LogE((x + 1) / (x - 1)) / 2;
        }

        /// <summary>
        /// areasekans hyperbolicus
        /// </summary>
        public static double Asech(this IMathClause math, double x)
        {
            return math.LogE((math.Sqrt(-x * x + 1) + 1) / x);
        }

        /// <summary>
        /// areakosekans hyperbolicus
        /// </summary>
        public static double Acsch(this IMathClause math, double x)
        {
            return math.LogE((math.Sign(x) * math.Sqrt(x * x + 1) + 1) / x);
        }
    }

}