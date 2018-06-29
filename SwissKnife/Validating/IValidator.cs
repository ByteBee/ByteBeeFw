using System;
using System.Collections.Generic;

namespace SwissKnife.Validating
{
    public interface IValidator<TObject>
    {
        void Validate(TObject obj);
        void Validate(TObject obj, bool crashOnError);
        IValidator<TObject> MustPass(Func<TObject, bool> check, string message);
        IValidator<TObject> MustFail(Func<TObject, bool> check, string message);

        IValidator<TObject> SubSequence<TOther>(IValidator<TOther> other, TOther obj, string message);
        IReadOnlyList<IValidationFailure> GetFailures();
    }
}