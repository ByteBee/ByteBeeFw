namespace ByteBee.Core.Validating
{
    public interface IValidator<in TObject>
    {
        ValidationResult Validate(TObject obj);
    }

    public interface IValidatorExceptional<in TObject>
    {
        void ValidateAndThrow(TObject obj);
    }
}