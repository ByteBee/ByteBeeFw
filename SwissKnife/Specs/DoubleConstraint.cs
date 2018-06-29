using System;

namespace SwissKnife.Specs
{
    public sealed class DoubleConstraint : Specification<double>
    {
        private readonly double? _min;
        private readonly double? _max;
        private readonly bool _exact;

        public DoubleConstraint(double? min, double? max)
            : this(min, max, true) { }

        public DoubleConstraint(double? min, double? max, bool exact)
        {
            _min = min;
            _max = max;
            _exact = exact;
        }

        public override bool IsSatisfiedBy(double candidate)
        {
            if (_exact)
            {
                if (_min.HasValue && candidate < _min.Value)
                    return false;
                if (_max.HasValue && candidate > _max.Value)
                    return false;
            }
            else
            {
                if (_min.HasValue && Math.Round(candidate, 6) < Math.Round(_min.Value, 6))
                    return false;
                if (_max.HasValue && Math.Round(candidate, 6) > Math.Round(_max.Value, 6))
                    return false;
            }

            return true;
        }
    }
}