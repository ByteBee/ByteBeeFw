using System;

namespace ByteBee.Core.Specifications
{
    public sealed class ExpresionSpec<TObj> : Specification<TObj>
    {
        private Func<TObj, bool> _expr;

        /// <inheritdoc />
        public ExpresionSpec(Func<TObj, bool> expression)
        {
            _expr = expression;
        }

        /// <inheritdoc />
        public override bool IsSatisfiedBy(TObj candidate) => _expr(candidate);
    }
}