using Business.Request.User;
using FluentValidation;

namespace Business.Profiles.Validation.User
{
    public class AddUserRequestValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(50);

        }
    }
}
