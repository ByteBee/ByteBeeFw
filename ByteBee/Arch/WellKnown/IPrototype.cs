using System;

// ReSharper disable UnusedMember.Global
namespace ByteBee.Arch.WellKnown
{
    public interface IPrototype<out TSelf> : ICloneable
    {
        TSelf ShallowCopy();
        TSelf DeepCopy();
        new TSelf Clone();
    }
}