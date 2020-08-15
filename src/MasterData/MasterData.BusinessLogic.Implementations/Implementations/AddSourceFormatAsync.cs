// <copyright file="AddSourceFormatAsync.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.BusinessLogic.Implementations
{
    using System;
    using System.Threading.Tasks;

    using Ctx;

    using DomainModel;

    using Exceptions;

    using FluentValidation;

    using Utils.Guards;

    using Validators;

    public partial class MasterDataBusinessLogic
    {
        public async Task<SourceFormat> AddSourceFormatAsync(SourceFormat sourceFormat)
        {
            using (MasterDataContext ctx = new MasterDataContext(_dbContextOptions))
            {
                using (var transaction = await ctx.Database.BeginTransactionAsync().ConfigureAwait(false))
                {
                    try
                    {
                        Check.IsNotNull(sourceFormat);
                        await _masterDataValidators.SourceFormatValidator.ValidateAndThrowAsync(
                                sourceFormat,
                                ruleSet: SourceFormatValidatorRulesets.Add)
                           .ConfigureAwait(false);

                        await ctx.SourceFormats.AddAsync(sourceFormat)
                           .ConfigureAwait(false);
                        await ctx.SaveChangesAsync().ConfigureAwait(false);
                        await transaction.CommitAsync().ConfigureAwait(false);

                        return sourceFormat;
                    }
                    catch (Exception e)
                    {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                        throw new MasterDataBusinessLogicAddSourceFormatAsyncOperationException(e.Message, e);
                    }
                }
            }
        }
    }
}