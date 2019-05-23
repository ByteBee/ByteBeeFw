using System;
using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Enums.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public abstract class AngleUnit : BeeEnum<AngleUnit, int>
    {
        public static AngleUnit Rad { get; } = new RadiantUnit(1, "radiant");
        public static AngleUnit Deg { get; } = new DegreeUnit(2, "degree");

        protected AngleUnit(int value, string name) : base(value, name) { }

        public abstract double ToRad();
        public abstract double ToDeg();

        private class RadiantUnit : AngleUnit
        {
            public RadiantUnit(int value, string name) : base(value, name) { }
            public override double ToRad() => 1;
            public override double ToDeg() => 180 / Math.PI;
        }

        private class DegreeUnit : AngleUnit
        {
            public DegreeUnit(int value, string name) : base(value, name) { }
            public override double ToRad() => Math.PI / 180;
            public override double ToDeg() => 1;
        }
    }
}