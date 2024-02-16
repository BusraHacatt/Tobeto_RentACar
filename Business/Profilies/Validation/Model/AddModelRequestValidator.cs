using Business.Request.Model;
using FluentValidation;

namespace Business.Profiles.Validation.Model
{
    public class AddModelRequestValidator : AbstractValidator<AddModelRequest>
    {
        public AddModelRequestValidator()
        {
            RuleFor(x => x.BrandId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.FuelId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.TransmissionId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.Year).NotEmpty().GreaterThan((short)0);
            RuleFor(x => x.DailyPrice).NotEmpty().GreaterThan(0);

            //RuleFor(model => model.Name).Must(StartsWithA);

        }
        //private bool StartsWithA(string a)
        //{
        //    return g.StartsWith("A");
        //}
    }
}
