using System;
using System.Collections.Generic;

namespace SwissKnife.Validating
{
    public interface IValidatingContext<TObject>
    {
        IEnumerable<IValidationFailure> Compile(TObject obj);
    }


    public interface IValidatingContext<TObject, TProperty> : IValidatingContext<TObject>
    {
        IValidatingContext<TObject, TProperty> Must(Func<TProperty, bool> predicate);
        IValidatingContext<TObject, TProperty> NotNull();

        void WithMessage(string message);
    }

    public class ValidatingContext<TObject, TProperty> : IValidatingContext<TObject, TProperty>
    {
        private readonly IList<ValidationRule<TProperty>> _rules = new List<ValidationRule<TProperty>>();
        private string _message;

        public string PropertyName { get; set; }
        public Func<object, object> PropertyFunc { get; set; }

        public IValidatingContext<TObject, TProperty> Must(Func<TProperty, bool> predicate)
        {
            var error = new ValidationFailure($"{PropertyName} must be something other");
            var rule = new ValidationRule<TProperty>(predicate, error);

            _rules.Add(rule);

            return this;
        }

        public IValidatingContext<TObject, TProperty> NotNull()
        {
            var error = new ValidationFailure($"{PropertyName} must not be null");
            var rule = new ValidationRule<TProperty>(o => o != null, error);

            _rules.Add(rule);

            return this;
        }

        public void WithMessage(string message) => _message = message;

        public IEnumerable<IValidationFailure> Compile(TObject obj)
        {
            foreach (ValidationRule<TProperty> rule in _rules)
            {
                var prop = (TProperty)PropertyFunc(obj);
                bool isValid = rule.Assert(prop);

                if (!isValid)
                {
                    if (string.IsNullOrWhiteSpace(_message))
                    {
                        yield return rule.Failure;
                    }
                    else
                    {
                        yield return new ValidationFailure(_message);
                        yield break;
                    }

                }
            }
        }
    }
}