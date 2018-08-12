using System;

namespace SwissKnife.Validating
{
    public interface IValidator<TObject>
    {
        ValidationResult Validate(TObject obj);
        void ValidateAndThrow(TObject obj);

        IValidator<TObject> ShouldBeTrue(Func<TObject, bool> check, string message);
        IValidator<TObject> ShouldBeFalse(Func<TObject, bool> check, string message);
        IValidator<TObject> Rule(Func<TObject, bool> check, string message);
        IValidator<TObject> RuleSet<TOther>(AbstrValidator<TOther> other, TOther obj, string message);
        IValidator<TObject> Include(AbstrValidator<TObject> other);


    }
}