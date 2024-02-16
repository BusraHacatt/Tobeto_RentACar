using Business.Request.Customer;
using FluentValidation;

namespace Business.Profiles.Validation.Customer
{
    public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequest>
    {
        public AddCustomerRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);

        }
    }
}