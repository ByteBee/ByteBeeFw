using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Arch.DesignPattern
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IFactory<out TProduct, in TParam>
    {
        TProduct Create(TParam what);
    }
}