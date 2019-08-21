using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Arch.WellKnown
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IBuilder<out TProduct>
    {
        void Reset();
        TProduct GetResult();
    }
}