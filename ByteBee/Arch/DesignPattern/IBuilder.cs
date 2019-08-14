using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Core.Arch.DesignPattern
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IBuilder<out TProduct>
    {
        void Reset();
        TProduct GetResult();
    }
}