namespace ByteBee.Core.Specifications
{
    public abstract class Specification<TObj>
    {
        public abstract bool IsSatisfiedBy(TObj candidate);

        public virtual bool IsNotSatisfiedBy(TObj candidate)
            => !IsSatisfiedBy(candidate);

        public Specification<TObj> And(Specification<TObj> other)
            => new AndSpecification<TObj>(this, other);

        public Specification<TObj> Or(Specification<TObj> other)
            => new OrSpecification<TObj>(this, other);

        /// <summary>
        /// antivalence
        /// </summary>
        public Specification<TObj> Xor(Specification<TObj> other)
            => new XorSpecification<TObj>(this, other);

        /// <summary>
        /// not and
        /// </summary>
        public Specification<TObj> Nand(Specification<TObj> other)
            => new NotSpecification<TObj>(new AndSpecification<TObj>(this, other));

        /// <summary>
        /// not or
        /// </summary>
        public Specification<TObj> Nor(Specification<TObj> other)
            => new NotSpecification<TObj>(new OrSpecification<TObj>(this, other));

        /// <summary>
        /// equivalence
        /// </summary>
        public Specification<TObj> Xnor(Specification<TObj> other)
            => new NotSpecification<TObj>(new XorSpecification<TObj>(this, other));

        public static Specification<TObj> operator *(Specification<TObj> a, Specification<TObj> b) => a.And(b);
        public static Specification<TObj> operator +(Specification<TObj> a, Specification<TObj> b) => a.Or(b);

        public static Specification<TObj> operator &(Specification<TObj> a, Specification<TObj> b) => a.And(b);
        public static Specification<TObj> operator |(Specification<TObj> a, Specification<TObj> b) => a.Or(b);
        public static Specification<TObj> operator ^(Specification<TObj> a, Specification<TObj> b) => a.Xor(b);
    }
}