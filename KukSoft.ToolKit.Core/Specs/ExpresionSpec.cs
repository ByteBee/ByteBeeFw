using System;

namespace KukSoft.ToolKit.Specs
{
    public sealed class ExpresionSpec<TObj> : Specification<TObj>
    {
        private Func<TObj, bool> _expr;

        public ExpresionSpec(Func<TObj, bool> expression)
        {
            _expr = expression;
        }

        public override bool IsSatisfiedBy(TObj candidate) => _expr(candidate);
    }
}