// Digital Library project
// https://github.com/SayusiAndo/DigitalLibrary
// Licensed under MIT License

namespace DigitalLibrary.ControlPanel.Validators
{
    using DomainModel.Entities;

    using FluentValidation;

    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleSet(ValidatorRulesets.AddNew, () =>
            {
                When(p => p.Name == null, () => { RuleFor(p => p.Name).NotNull(); });
                RuleFor(p => p.Name).NotEmpty().NotEqual(" ");

                When(p => p.Description == null, () => { RuleFor(p => p.Description).NotNull(); });
                RuleFor(p => p.Description).NotEmpty().NotEqual(" ");

                When(p => p.MenuRoute == null, () => { RuleFor(p => p.MenuRoute).NotNull(); });
                RuleFor(p => p.MenuRoute).NotEmpty().NotEqual(" ");

                RuleFor(p => p.Id).Equal(0);
                RuleFor(p => p.ModuleId).NotEqual(0);

                RuleFor(p => p.IsActive).GreaterThanOrEqualTo(0).LessThanOrEqualTo(1);
            });

            RuleSet(ValidatorRulesets.Delete, () => { });

            RuleSet(ValidatorRulesets.Modify, () => { });

            RuleSet(ValidatorRulesets.Find, () => { RuleFor(p => p.Id).NotEqual(0); });
        }
    }
}