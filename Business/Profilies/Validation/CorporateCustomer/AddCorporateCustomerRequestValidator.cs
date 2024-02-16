using Business.Request.CorporateCustomer;
using FluentValidation;

namespace Business.Profiles.Validation.CorporateCustomer
{
    public class AddCorporateCustomerRequestValidator : AbstractValidator<AddCorporateRequest>
    {
        public AddCorporateCustomerRequestValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().MinimumLength(2).MaximumLength(150);
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.TaxNo).NotEmpty().Must(x => x.Length == 10);
        }
    }
}