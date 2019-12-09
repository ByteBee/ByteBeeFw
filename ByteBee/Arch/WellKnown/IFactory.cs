// ReSharper disable UnusedMember.Global
namespace ByteBee.Arch.WellKnown
{
    public interface IFactory<out TProduct, in TParam>
    {
        TProduct Create(TParam what);
    }
}