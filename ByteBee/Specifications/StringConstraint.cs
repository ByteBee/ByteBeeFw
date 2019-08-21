using ByteBee.Extensions;

namespace ByteBee.Specifications
{
    public sealed class StringConstraint : Specification<string>
    {
        private readonly uint? _minLength;
        private readonly uint? _maxLength;
        private readonly bool _nullAllowed;
        private readonly bool _emptyAllowed;

        /// <inheritdoc />
        public StringConstraint(uint? minLength, uint? maxLength)
            : this(minLength, maxLength, false, true) { }

        /// <inheritdoc />
        public StringConstraint(uint? minLength, uint? maxLength, bool nullAllowed, bool emptyAllowed)
        {
            _minLength = minLength;
            _maxLength = maxLength;
            _nullAllowed = nullAllowed;
            _emptyAllowed = emptyAllowed;
        }

        /// <inheritdoc />
        public override bool IsSatisfiedBy(string candidate)
        {
            if (_nullAllowed && candidate == null)
                return true;
            if (!_emptyAllowed && candidate.IsEmpty())
                return false;
            if (_minLength.HasValue && candidate.Length < _minLength.Value)
                return false;
            if (_maxLength.HasValue && candidate.Length > _maxLength.Value)
                return false;

            return true;
        }
    }
}