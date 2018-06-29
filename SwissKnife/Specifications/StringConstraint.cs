using SwissKnife.Extensions;

namespace SwissKnife.Specifications
{
    public sealed class StringConstraint : Specification<string>
    {
        private readonly uint? _minLength;
        private readonly uint? _maxLength;
        private readonly bool _nullAllowed;
        private readonly bool _emptyAllowed;

        public StringConstraint(uint? minLength, uint? maxLength)
            : this(minLength, maxLength, false, true) { }

        public StringConstraint(uint? minLength, uint? maxLength, bool nullAllowed, bool emptyAllowed)
        {
            _minLength = minLength;
            _maxLength = maxLength;
            _nullAllowed = nullAllowed;
            _emptyAllowed = emptyAllowed;
        }

        public override bool IsSatisfiedBy(string candidate)
        {
            if (_nullAllowed && candidate == null)
                return true;
            if (!_emptyAllowed && candidate.IsNullOrEmpty())
                return false;
            if (_minLength.HasValue && candidate.Length < _minLength.Value)
                return false;
            if (_maxLength.HasValue && candidate.Length > _maxLength.Value)
                return false;

            return true;
        }
    }
}