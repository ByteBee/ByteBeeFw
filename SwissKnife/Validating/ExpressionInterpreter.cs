using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;
using static SwissKnife.Fancy;

namespace SwissKnife.Validating
{
    class ExpressionInterpreter<TObject, TProperty>
    {
        private readonly ValidatorOptions _options;
        public ExpressionInterpreter(ValidatorOptions options) => _options = options;

        public string GetName(Expression<Func<TObject, TProperty>> expression)
        {
            if (expression.Body is MemberExpression memberExpr)
            {
                return GetPropertyName(memberExpr);
            }

            if (expression.Body is MethodCallExpression methodExpr)
            {
                return GetMethodName(methodExpr);
            }

            guard.Throws<InvalidExpressionException>($"Unknown Expression type for '{expression.Body}'");
            return string.Empty;
        }

        private string GetPropertyName(MemberExpression memberExpr)
        {
            MemberInfo member = memberExpr.Member;
            return BuildName(new PropertyBuilder(member));
        }

        private string GetMethodName(MethodCallExpression methodExpr)
        {
            MethodInfo method = methodExpr.Method;


            string methodName = BuildName(new MethodBuilder(method));
            string methodStub = string.Empty;

            if (_options.ShowMethodStub)
            {
                string rettype = BuildName(new TypeBuilder(method.ReturnType));

                methodStub += rettype;

                var args = new List<string>();
                foreach (Expression arg in methodExpr.Arguments)
                {
                    args.Add(BuildName(new TypeBuilder(arg.Type)));
                }

                methodStub += $" {methodName}(";
                methodStub += string.Join(", ", args);
                methodStub += ")";
            }
            else
            {
                methodStub = methodName;
            }

            return methodStub;
        }

        private interface IBuilder
        {
            void BuildNamespace();
            void BuildClass();
            void BuildName();
            string GetResult();
        }

        private class MethodBuilder : IBuilder
        {
            private readonly IList<string> _names = new List<string>();
            private readonly MethodInfo _info;
            public MethodBuilder(MethodInfo info) => _info = info;
            public void BuildNamespace() => _names.Add(_info.DeclaringType?.Namespace);
            public void BuildClass() => _names.Add(_info.DeclaringType?.Name);
            public void BuildName() => _names.Add(_info.Name);
            public string GetResult() => string.Join(".", _names);
        }

        private class PropertyBuilder : IBuilder
        {
            private readonly IList<string> _names = new List<string>();
            private readonly MemberInfo _info;
            public PropertyBuilder(MemberInfo info) => _info = info;
            public void BuildNamespace() => _names.Add(_info.DeclaringType?.Namespace);
            public void BuildClass() => _names.Add(_info.DeclaringType?.Name);
            public void BuildName() => _names.Add(_info.Name);
            public string GetResult() => string.Join(".", _names);
        }

        private class TypeBuilder : IBuilder
        {
            private readonly IList<string> _names = new List<string>();
            private readonly Type _info;
            public TypeBuilder(Type info) => _info = info;
            public void BuildNamespace() => _names.Add(_info.Namespace);
            public void BuildClass() { }
            public void BuildName() => _names.Add(_info.Name);
            public string GetResult() => string.Join(".", _names);
        }

        private string BuildName(IBuilder builder)
        {
            if (_options.ShowNamespace)
            {
                builder.BuildNamespace();
            }

            if (_options.ShowClass)
            {
                builder.BuildClass();
            }

            builder.BuildName();

            return builder.GetResult();
        }


        public Func<TObject, TProperty> GetFunction(Expression<Func<TObject, TProperty>> expression)
            => expression.Compile();
    }

    internal class ValidatorOptions
    {
        public bool ShowNamespace { get; set; }
        public bool ShowClass { get; set; }
        public bool ShowMethodStub { get; set; }
    }
}