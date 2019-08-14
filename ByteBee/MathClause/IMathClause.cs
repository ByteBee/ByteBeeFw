namespace ByteBee.Core.MathClause
{
    public interface IMathClause
    {
        double Euler { get; }
        double Epsilon { get; }
        double ZeroTolerance { get; }
        double Pi { get; }
        double Pi2 { get; }
        double Pi4 { get; }
        double PiOver2 { get; }

        double Sqrt2 { get; }
        double Sqrt3 { get; }
        double Sqrt5 { get; }
    }

    internal class BeeMathImpl : IMathClause
    {
        public double Euler { get; } = 2.7182818284590452353602874713526624;
        public double Epsilon { get; } = 1E-9;
        public double ZeroTolerance { get; } = 1E-06;

        public double Pi { get; } = 3.1415926535897932384626433832795;
        public double Pi2 { get; } = 6.283185307179586476925286766559;
        public double Pi4 { get; } = 12.566370614359172953850573533118;
        public double PiOver2 { get; } = 1.5707963267948966192313216916398;

        public double Sqrt2 { get; } = 1.41421356237309504880168872420969807;
        public double Sqrt3 { get; } = 1.73205080756887729352744634150587236;
        public double Sqrt5 { get; } = 2.23606797749978969640917366873127623;
    }
}