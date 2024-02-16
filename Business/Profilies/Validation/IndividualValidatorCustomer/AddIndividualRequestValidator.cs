﻿using Business.Request.IndividualCustomer;
using FluentValidation;

namespace Business.Profiles.Validation.IndividualCustomer
{
    public class AddIndividualRequestValidator : AbstractValidator<AddIndividualRequest>
    {
        public AddIndividualRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(60);
            RuleFor(x => x.NationalIdentity).NotEmpty().Must(x => x.Length == 11);
            RuleFor(x => x.CustomerId).NotEmpty();
        }
    }
}
