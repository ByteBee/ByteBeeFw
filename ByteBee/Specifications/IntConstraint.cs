﻿namespace ByteBee.Specifications
{
    public sealed class IntConstraint : Specification<int>
    {
        private readonly int? _min;
        private readonly int? _max;

        /// <inheritdoc />
        public IntConstraint(int? min, int? max)
        {
            _min = min;
            _max = max;
        }

        /// <inheritdoc />
        public override bool IsSatisfiedBy(int candidate)
        {
            if (_min.HasValue && candidate < _min.Value)
                return false;
            if (_max.HasValue && candidate > _max.Value)
                return false;

            return true;
        }
    }
}