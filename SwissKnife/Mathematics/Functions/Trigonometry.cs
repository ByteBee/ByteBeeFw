using System;

namespace SwissKnife.Mathematics.Functions
{
    public partial interface IMathFunctions
    {
        double Sin(double angle);
        double Cos(double angle);
        double Tan(double angle);
        double Cot(double angle);
        double Sec(double angle);
        double Csc(double angle);

        double Acos(double angle);
        double Asin(double angle);
        double Atan(double angle);
        double Acot(double angle);
        double Asec(double angle);
        double Acsc(double angle);

        double Sinh(double angle);
        double Cosh(double angle);
        double Tanh(double angle);
        double Coth(double angle);
        double Sech(double angle);
        double Csch(double angle);

        double Asinh(double angle);
        double Acosh(double angle);
        double Atanh(double angle);
        double Acoth(double angle);
        double Asech(double angle);
        double Acsch(double angle);
    }

    internal partial class MathFunctions : IMathFunctions
    {
        public double Sin(double angle) => Math.Sin(angle);
        public double Cos(double angle) => Math.Cos(angle);
        public double Tan(double angle) => Math.Tan(angle);
        public double Csc(double angle) => 1 / Sin(angle);
        public double Sec(double angle) => 1 / Cos(angle);
        public double Cot(double angle) => 1 / Tan(angle);

        public double Asin(double angle) => Math.Asin(angle);
        public double Acos(double angle) => Math.Acos(angle);
        public double Atan(double angle) => Math.Atan(angle);
        public double Acsc(double angle) => 1 / Asin(angle);
        public double Asec(double angle) => 1 / Cos(angle);
        public double Acot(double angle) => 1 / Atan(angle);

        public double Sinh(double angle) => Math.Sinh(angle);
        public double Cosh(double angle) => Math.Cosh(angle);
        public double Tanh(double angle) => Math.Tanh(angle);
        public double Coth(double angle) => 1 / Tanh(angle);
        public double Sech(double angle) => 1 / Cosh(angle);
        public double Csch(double angle) => 1 / Sinh(angle);

        public double Asinh(double angle) => Math.Pow(Sinh(angle), -1);
        public double Acosh(double angle) => Math.Pow(Cosh(angle), -1);
        public double Atanh(double angle) => Math.Pow(Tanh(angle), -1);
        public double Acoth(double angle) => Math.Pow(Coth(angle), -1);
        public double Asech(double angle) => Math.Pow(Sech(angle), -1);
        public double Acsch(double angle) => Math.Pow(Csch(angle), -1);
    }
}