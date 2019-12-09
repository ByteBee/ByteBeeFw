// ReSharper disable UnusedMember.Global
namespace ByteBee.Arch.WellKnown
{
    public interface IBuilder<out TProduct>
    {
        void Reset();
        TProduct GetResult();
    }
}