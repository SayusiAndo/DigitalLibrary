// Digital Library project
// https://github.com/SayusiAndo/DigitalLibrary
// Licensed under MIT License

namespace DigitalLibrary.MasterData.Validators
{
    using System.Diagnostics.CodeAnalysis;

    using DomainModel;

    using FluentValidation;

    [ExcludeFromCodeCoverage]
    public class SourceFormatValidator : AbstractValidator<SourceFormat>
    {
        public SourceFormatValidator()
        {
            RuleSet(SourceFormatValidatorRulesets.Add, () =>
            {
                When(w => w.Name == null || w.Desc == null, () =>
                {
                    RuleFor(e => e.Name).NotNull();
                    RuleFor(e => e.Desc).NotNull();
                });

                When(w => w.Name != null && w.Desc != null, () =>
                {
                    RuleFor(p => p.Id).Equal(0);
                    RuleFor(p => p.Name).NotEmpty().NotEqual(" ");
                    RuleFor(p => p.Name.Length).GreaterThanOrEqualTo(3);
                    RuleFor(p => p.Desc).NotEmpty().NotEqual(" ");
                    RuleFor(p => p.Desc.Length).GreaterThanOrEqualTo(3);
                    RuleFor(p => p.IsActive).GreaterThanOrEqualTo(0).LessThanOrEqualTo(1);
                });
            });

            // RuleSet(SourceFormatValidatorRulesets.AddSourceFormat, () =>
            // {
            //     When(w => w.Name == null || w.Desc == null, () =>
            //     {
            //         RuleFor(e => e.Name).NotNull();
            //         RuleFor(e => e.Desc).NotNull();
            //     });
            //
            //     When(w => w.Name != null && w.Desc != null, () =>
            //     {
            //         RuleFor(p => p.Id).Equal(0);
            //         // RuleFor(p => p.ParentDimensionStructureId).Equal(0);
            //         RuleFor(p => p.Name).NotEmpty().NotEqual(" ");
            //         RuleFor(p => p.Name.Length).GreaterThanOrEqualTo(3);
            //         RuleFor(p => p.Desc).NotEmpty().NotEqual(" ");
            //         RuleFor(p => p.Desc.Length).GreaterThanOrEqualTo(3);
            //         RuleFor(p => p.IsActive).GreaterThanOrEqualTo(0).LessThanOrEqualTo(1);
            //     });
            // });

            RuleSet(SourceFormatValidatorRulesets.Update, () =>
            {
                When(w => w.Name == null || w.Desc == null, () =>
                {
                    RuleFor(e => e.Name).NotNull();
                    RuleFor(e => e.Desc).NotNull();
                });
                When(w => w.Name != null && w.Desc != null, () =>
                {
                    RuleFor(p => p.Id).GreaterThan(0);
                    // RuleFor(p => p.ParentDimensionStructureId).Equal(0);
                    RuleFor(p => p.Name.Length).GreaterThanOrEqualTo(3);
                    RuleFor(p => p.Name).NotNull().NotEmpty().NotEqual(" ");
                    RuleFor(p => p.Desc.Length).GreaterThanOrEqualTo(3);
                    RuleFor(p => p.Desc).NotEmpty().NotEqual(" ");
                    RuleFor(p => p.IsActive).GreaterThanOrEqualTo(0).LessThanOrEqualTo(1);
                });
            });

            RuleSet(SourceFormatValidatorRulesets.Delete, () => { RuleFor(p => p.Id).NotEqual(0); });
            RuleSet(SourceFormatValidatorRulesets.GetById, () => { RuleFor(p => p.Id).GreaterThan(0); });
        }
    }
}