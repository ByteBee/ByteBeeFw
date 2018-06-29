namespace SwissKnife.Specifications
{
    class NotSpecification<TObj> : Specification<TObj>
    {
        private readonly Specification<TObj> _spec;

        public NotSpecification(Specification<TObj> spec)
        {
            _spec = spec;
        }

        public override bool IsSatisfiedBy(TObj candidate)
            => !_spec.IsSatisfiedBy(candidate);
    }
}