namespace KukSoft.ToolKit.Specs
{
    class XorSpecification<TObj> : Specification<TObj>
    {
        private readonly Specification<TObj> _one;
        private readonly Specification<TObj> _two;

        public XorSpecification(Specification<TObj> one, Specification<TObj> two)
        {
            _one = one;
            _two = two;
        }

        public override bool IsSatisfiedBy(TObj candidate)
            => _one.IsSatisfiedBy(candidate) ^ _two.IsSatisfiedBy(candidate);
    }
}