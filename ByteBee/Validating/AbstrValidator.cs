using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ByteBee.Validating
{
    public abstract class AbstrValidator<TObject> : IValidator<TObject>, IValidatorExceptional<TObject>
    {
        internal readonly IList<IValidatingContext<TObject>> Rules = new List<IValidatingContext<TObject>>();

        /// <inheritdoc />
        public ValidationResult Validate(TObject obj)
        {
            var allErrors = new List<IValidationFailure>();
            foreach (IValidatingContext<TObject> rule in Rules)
            {
                List<IValidationFailure> errors = rule.Compile(obj).ToList();

                allErrors.AddRange(errors);
            }

            return new ValidationResult(allErrors);
        }

        /// <inheritdoc />
        public void ValidateAndThrow(TObject obj)
        {
            ValidationResult result = Validate(obj);

            if (!result.IsValid)
            {
                Bee.Guard.Throws<ObjectNotValidException>(result.ToString());
            }
        }

        ///// <inheritdoc />
        //public IValidator<TObject> RuleSet<TOther>(AbstrValidator<TOther> other, TOther obj, string message)
        //{
        //    ValidationResult result = other.Validate(obj);
        //    //if (!result.IsValid)
        //    //{
        //    //    var failure = new ValidationFailure(message, result.Errors);
        //    //    Rules.Add(new ValidationRule<TObject>(o => true, failure, false));
        //    //}

        //    return this;
        //}

        /// <inheritdoc />
        public IValidator<TObject> Include(AbstrValidator<TObject> other)
        {
            foreach (IValidatingContext<TObject> rule in other.Rules)
            {
                Rules.Add(rule);
            }

            return this;
        }

        public IValidatingContext<TObject, TProperty> RuleFor<TProperty>(Expression<Func<TObject, TProperty>> expression)
        {
            var options = new ValidatorOptions();


            var intr = new ExpressionInterpreter<TObject, TProperty>(options);
            string name = intr.GetName(expression);
            Func<TObject, TProperty> func = intr.GetFunction(expression);

            var context = new ValidatingContext<TObject, TProperty>
            {
                PropertyName = name,
                PropertyFunc = x => func((TObject)x)
            };

            Rules.Add(context);
            return context;
        }

        public IValidatingContext<TObject, TProperty> RuleForEach<TProperty>(Expression<Func<TObject, IEnumerable<TProperty>>> expression)
        {
            return null;
        }
    }
}