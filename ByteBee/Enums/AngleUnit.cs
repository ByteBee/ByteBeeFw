using System;
using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Core.Enums
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public abstract class AngleUnit : BeeEnum<AngleUnit, int>
    {
        public static AngleUnit Rad { get; } = new RadianUnit(1, "radian");
        public static AngleUnit Deg { get; } = new DegreeUnit(2, "degree");
        public static AngleUnit Gon { get; } = new GonUnit(3, "grad");

        private AngleUnit(int value, string name) : base(value, name)
        {
        }

        public abstract double ToRad();
        public abstract double ToDeg();
        public abstract double ToGon();

        private sealed class RadianUnit : AngleUnit
        {
            public RadianUnit(int value, string name) : base(value, name)
            {
            }

            public override double ToRad()
            {
                return 1;
            }

            public override double ToDeg()
            {
                return 180 / Math.PI;
            }

            public override double ToGon()
            {
                return 200 / Math.PI;
            }
        }

        private sealed class DegreeUnit : AngleUnit
        {
            public DegreeUnit(int value, string name) : base(value, name)
            {
            }

            public override double ToRad()
            {
                return Math.PI / 180;
            }

            public override double ToDeg()
            {
                return 1;
            }

            public override double ToGon()
            {
                return 10d / 9d;
            }
        }

        private sealed class GonUnit : AngleUnit
        {
            public GonUnit(int value, string name) : base(value, name)
            {
            }

            public override double ToRad()
            {
                return Math.PI / 200;
            }

            public override double ToDeg()
            {
                return 0.9;
            }

            public override double ToGon()
            {
                return 1;
            }
        }
    }
}