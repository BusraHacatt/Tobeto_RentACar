using FluentValidation;
using FluentValidation.Results;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object objectToValidate)
        {
            ValidationContext<object> context = new(objectToValidate); 
            ValidationResult result = validator.Validate(context); 
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
