namespace SwissKnife.Utilities
{
    public interface IMath
    {
        double Epsilon { get; set; }
        double ZeroTolerance { get; set; }
    }

    public abstract class MathAdapter:IMath
    {
        public double Epsilon { get; set; } = 2.2204460492503131e-016;
        public double ZeroTolerance { get; set; } = 1E-08;
    }

    internal class MathImpl : MathAdapter { }
}