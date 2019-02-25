using System;

namespace ByteBee.Arch.DesignPattern
{
    public interface IPrototype<out TSelf> : ICloneable
    {
        TSelf ShallowCopy();
        TSelf DeepCopy();
        new TSelf Clone();
    }
}