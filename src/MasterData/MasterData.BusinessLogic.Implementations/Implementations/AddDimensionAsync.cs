using System;
using System.Threading.Tasks;

using DigitalLibrary.MasterData.Ctx.Ctx;
using DigitalLibrary.MasterData.DomainModel.DomainModel;
using DigitalLibrary.MasterData.Validators.Validators;

using FluentValidation;

namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Implementations
{
    using Exceptions;

    public partial class MasterDataBusinessLogic
    {
        public async Task<Dimension> AddDimensionAsync(Dimension dimension)
        {
            try
            {
                if (dimension == null)
                {
                    throw new MasterDataBusinessLogicArgumentNullException(nameof(dimension));
                }

                await _masterDataValidators.DimensionValidator.ValidateAndThrowAsync(
                        dimension,
                        ruleSet: ValidatorRulesets.AddNewDimension)
                   .ConfigureAwait(false);

                using (MasterDataContext ctx = new MasterDataContext(_dbContextOptions))
                {
                    await ctx.Dimensions.AddAsync(dimension)
                       .ConfigureAwait(false);
                    await ctx.SaveChangesAsync().ConfigureAwait(false);

                    return dimension;
                }
            }
            catch (Exception e)
            {
                throw new MasterDataBusinessLogicAddDimensionAsyncOperationException(e.Message, e);
            }
        }
    }
}