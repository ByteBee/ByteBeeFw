using System;
using ByteBee.Enums;

namespace ByteBee.Numerics
{
    public static class Trig
    {
        /// <summary>
        /// sine (rad)
        /// </summary>
        public static double Sin(double theta)
        {
            return Math.Sin(theta);
        }

        /// <summary>
        /// sine
        /// </summary>
        public static double Sin(double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return Sin(theta);
        }

        /// <summary>
        /// cosine
        /// </summary>
        public static double Cos(double theta)
        {
            return Math.Cos(theta);
        }

        /// <summary>
        /// cosine
        /// </summary>
        public static double Cos(double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return Cos(theta);
        }

        /// <summary>
        /// tangent (rad)
        /// </summary>
        public static double Tan(double theta)
        {
            return Math.Tan(theta);
        }

        /// <summary>
        /// tangent
        /// </summary>
        public static double Tan(double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return Tan(theta);
        }

        /// <summary>
        /// cosecant (rad)
        /// </summary>
        public static double Csc(double theta)
        {
            return 1 / Math.Sin(theta);
        }

        /// <summary>
        /// cosecant
        /// </summary>
        public static double Csc(double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return Csc(theta);
        }

        /// <summary>
        /// secant (rad)
        /// </summary>
        public static double Sec(double theta)
        {
            return 1 / Math.Cos(theta);
        }

        /// <summary>
        /// secant
        /// </summary>
        public static double Sec(double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return Sec(theta);
        }

        /// <summary>
        /// cotangent (rad)
        /// </summary>
        public static double Cot(double theta)
        {
            return 1 / Math.Tan(theta);
        }

        /// <summary>
        /// cotangent
        /// </summary>
        public static double Cot(double theta, AngleUnit angle)
        {
            theta *= angle.ToRad();
            return Cot(theta);
        }
        /*
        /// <summary>
        /// arcus sine (rad)
        /// </summary>
        public static double Asin(double theta)
        {
            return Math.Asin(theta);
        }

        /// <summary>
        /// arcus sine
        /// </summary>
        public static double Asin(double theta, AngleUnit angle)
        {
            return Asin(theta) / angle.ToRad();
        }

        /// <summary>
        /// arcus cosine (rad)
        /// </summary>
        public static double Acos(double theta)
        {
            return Math.Acos(theta);
        }

        /// <summary>
        /// arcus cosine
        /// </summary>
        public static double Acos(double theta, AngleUnit angle)
        {
            return Acos(theta) / angle.ToRad();
        }
        /// <summary>
        /// arcus tangent (rad)
        /// </summary>
        public static double Atan(double theta)
        {
            return Math.Atan(theta);
        }

        /// <summary>
        /// arcus tangent
        /// </summary>
        public static double Atan(double theta, AngleUnit angle)
        {
            return Atan(theta) / angle.ToRad();
        }

        /// <summary>
        /// arcus cosecant (rad)
        /// </summary>
        public static double Acsc(double theta)
        {
            return Atan(Math.Sign(theta) / Math.Sqrt(theta * theta - 1));
        }

        /// <summary>
        /// arcus cosecant
        /// </summary>
        public static double Acsc(double theta, AngleUnit angle)
        {
            return Acsc(theta) / angle.ToRad();
        }

        /// <summary>
        /// arcus secant (rad)
        /// </summary>
        public static double Asec(double theta)
        {
            return 2 * Atan(1) - Atan(Math.Sign(theta) / Math.Sqrt(theta * theta - 1));
        }

        /// <summary>
        /// arcus secant
        /// </summary>
        public static double Asec(double theta, AngleUnit angle)
        {
            return Asec(theta) / angle.ToRad();
        }

        /// <summary>
        /// arcus cotangent (rad)
        /// </summary>
        public static double Acot(double theta)
        {
            return 2 * Atan(1) - Atan(theta);
        }

        /// <summary>
        /// arcus cotangent
        /// </summary>
        public static double Acot(double theta, AngleUnit angle)
        {
            return Acot(theta) / angle.ToRad();
        }

        /// <summary>
        /// Sinus hyperbolicus
        /// </summary>
        public static double Sinh(double theta)
        {
            return Math.Sinh(theta);
        }
        
        /// <summary>
        /// Sinus hyperbolicus
        /// </summary>
        public static double Sinh(double theta, AngleUnit angle)
        {
            return Math.Sinh(theta);
        }
        
        /// <summary>
        /// Kosinus hyperbolicus
        /// </summary>
        public static double Cosh(double theta)
        {
            return Math.Cosh(theta);
        }

        /// <summary>
        /// Kosinus hyperbolicus
        /// </summary>
        public static double Cosh(double theta, AngleUnit angle)
        {
            return Math.Cosh(theta);
        }

        /// <summary>
        /// Tangens hyperbolicus
        /// </summary>
        public static double Tanh(double theta)
        {
            return Math.Tanh(theta);
        }

        /// <summary>
        /// Tangens hyperbolicus
        /// </summary>
        public static double Tanh(double theta, AngleUnit angle)
        {
            return Math.Tanh(theta);
        }

        /// <summary>
        /// Kotangens hyperbolicus
        /// </summary>
        public static double Coth(double theta)
        {
            return (Math.Exp(theta) + Math.Exp(-theta)) / (Math.Exp(theta) - Math.Exp(-theta));
        }

        /// <summary>
        /// Kotangens hyperbolicus
        /// </summary>
        public static double Coth(double theta, AngleUnit angle)
        {
            return (Math.Exp(theta) + Math.Exp(-theta)) / (Math.Exp(theta) - Math.Exp(-theta));
        }

        /// <summary>
        /// Sekans hyperbolicus
        /// </summary>
        public static double Sech(double theta)
        {
            return 2 / (Math.Exp(theta) + Math.Exp(theta));
        }

        /// <summary>
        /// Sekans hyperbolicus
        /// </summary>
        public static double Sech(double theta, AngleUnit angle)
        {
            return 2 / (Math.Exp(theta) + Math.Exp(theta));
        }

        /// <summary>
        /// Kosekans hyperbolicus
        /// </summary>
        public static double Csch(double theta)
        {
            return 2 / (Math.Exp(theta) - Math.Exp(theta));
        }

        /// <summary>
        /// Kosekans hyperbolicus
        /// </summary>
        public static double Csch(double theta, AngleUnit angle)
        {
            return 2 / (Math.Exp(theta) - Math.Exp(theta));
        }

        /// <summary>
        /// areasinus hyperbolicus
        /// </summary>
        public static double Asinh(double theta)
        {
            return Math.Log(theta + Math.Sqrt(theta * theta + 1));
        }

        /// <summary>
        /// areasinus hyperbolicus
        /// </summary>
        public static double Asinh(double theta, AngleUnit angle)
        {
            return Math.Log(theta + Math.Sqrt(theta * theta + 1));
        }

        /// <summary>
        /// areakosinus hyperbolicus
        /// </summary>
        public static double Acosh(double theta)
        {
            return Math.Log(theta + Math.Sqrt(theta * theta - 1));
        }

        /// <summary>
        /// areakosinus hyperbolicus
        /// </summary>
        public static double Acosh(double theta, AngleUnit angle)
        {
            return Math.Log(theta + Math.Sqrt(theta * theta - 1));
        }

        /// <summary>
        /// areatangens hyperbolicus
        /// </summary>
        public static double Atanh(double theta)
        {
            return Math.Log((1 + theta) / (1 - theta)) / 2;
        }

        /// <summary>
        /// areatangens hyperbolicus
        /// </summary>
        public static double Atanh(double theta, AngleUnit angle)
        {
            return Math.Log((1 + theta) / (1 - theta)) / 2;
        }

        /// <summary>
        /// areakotangens hyperbolicus
        /// </summary>
        public static double Acoth(double theta)
        {
            return Math.Log((theta + 1) / (theta - 1)) / 2;
        }

        /// <summary>
        /// areakotangens hyperbolicus
        /// </summary>
        public static double Acoth(double theta, AngleUnit angle)
        {
            return Math.Log((theta + 1) / (theta - 1)) / 2;
        }

        /// <summary>
        /// areasekans hyperbolicus
        /// </summary>
        public static double Asech(double theta)
        {
            return Math.Log((Math.Sqrt(-theta * theta + 1) + 1) / theta);
        }

        /// <summary>
        /// areasekans hyperbolicus
        /// </summary>
        public static double Asech(double theta, AngleUnit angle)
        {
            return Math.Log((Math.Sqrt(-theta * theta + 1) + 1) / theta);
        }

        /// <summary>
        /// areakosekans hyperbolicus
        /// </summary>
        public static double Acsch(double theta)
        {
            return Math.Log((Math.Sign(theta) * Math.Sqrt(theta * theta + 1) + 1) / theta);
        }

        /// <summary>
        /// areakosekans hyperbolicus
        /// </summary>
        public static double Acsch(double theta, AngleUnit angle)
        {
            return Math.Log((Math.Sign(theta) * Math.Sqrt(theta * theta + 1) + 1) / theta);
        }/**/
    }
}
