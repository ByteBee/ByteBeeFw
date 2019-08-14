using System;
using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Core.Arch.DesignPattern
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IPrototype<out TSelf> : ICloneable
    {
        TSelf ShallowCopy();
        TSelf DeepCopy();
        new TSelf Clone();
    }
}