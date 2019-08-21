namespace ByteBee.Specifications
{
    class AndSpecification<TObj> : Specification<TObj>
    {
        private readonly Specification<TObj> _left;
        private readonly Specification<TObj> _right;

        public AndSpecification(Specification<TObj> left, Specification<TObj> right)
        {
            _left = left;
            _right = right;
        }

        public override bool IsSatisfiedBy(TObj candidate)
            => _left.IsSatisfiedBy(candidate) && _right.IsSatisfiedBy(candidate);
    }
}