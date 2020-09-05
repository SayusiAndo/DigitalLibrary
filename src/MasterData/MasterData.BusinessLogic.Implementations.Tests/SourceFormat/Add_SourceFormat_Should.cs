// <copyright file="Add_SourceFormat_Should.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.SourceFormat
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.BusinessLogic.Exceptions;
    using DigitalLibrary.MasterData.DomainModel;

    using FluentAssertions;

    using Xunit;

    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Reviewed.")]
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "CA1707", Justification = "Reviewed.")]
    [SuppressMessage("ReSharper", "SA1600", Justification = "Reviewed.")]
    public class Add_SourceFormat_Should : TestBase
    {
        public Add_SourceFormat_Should()
            : base(TestInfo)
        {
        }

        private const string TestInfo = nameof(Add_SourceFormat_Should);

        [Fact]
        public async Task Add_WhenSourceFormat_DoesntHaveRootDimensionStructure()
        {
            // Arrange
            SourceFormat sourceFormat = new SourceFormat
            {
                Name = "name",
                Desc = "desc",
                IsActive = 1,
            };

            // Act
            SourceFormat result = await masterDataBusinessLogic.AddSourceFormatAsync(
                sourceFormat).ConfigureAwait(false);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().BeGreaterThan(0);
            result.Name.Should().Be(sourceFormat.Name);
            result.Desc.Should().Be(sourceFormat.Desc);
            result.IsActive.Should().Be(sourceFormat.IsActive);
        }

        [Fact]
        public async Task Add_WhenSourceFormatHasRootDimension_ButNoDimensionTree()
        {
        }

        [Fact]
        public async Task Add_WithOneLevelMultiple_DimensionStructureTree_DimensionStructuresAreExist()
        {
        }

        [Fact]
        public async Task Add_WithOneLevelMultiple_DimensionStructureTree_DimensionStructuresAreNew()
        {
        }

        [Fact]
        public async Task Add_WithOneLevelSingle_DimensionStructureTree_DimensionStructuresAreNew()
        {
        }

        [Fact]
        public async Task Add_WithOneLevelSingle_DimensionStructureTree_DimensionStructuresExist()
        {
        }

        [Fact]
        public async Task Add_WithoutCreatingDimensionStructure_WhenRootDimension_IsAlreadyAttached_ToOtherEntities()
        {
        }

        [Fact]
        public async Task Add_WithThreeLevelMultiple_DimensionStructureTree_DimensionStructuresAreExist()
        {
        }

        [Fact]
        public async Task Add_WithThreeLevelMultiple_DimensionStructureTree_DimensionStructuresAreNew()
        {
        }

        [Fact]
        public async Task Add_WithThreeLevelSingle_DimensionStructureTree_DimensionStructuresAreExist()
        {
        }

        [Fact]
        public async Task Add_WithThreeLevelSingle_DimensionStructureTree_DimensionStructuresAreNew()
        {
        }

        [Fact]
        public async Task Add_WithTwoLevelMultiple_DimensionStructureTree_DimensionStructuresAreExist()
        {
        }

        [Fact]
        public async Task Add_WithTwoLevelMultiple_DimensionStructureTree_DimensionStructuresAreNew()
        {
        }

        [Fact]
        public async Task Add_WithTwoLevelSingle_DimensionStructureTree_DimensionStructuresAreExist()
        {
        }

        [Fact]
        public async Task Add_WithTwoLevelSingle_DimensionStructureTree_DimensionStructuresAreNew()
        {
        }

        [Fact]
        public async Task ThrowExpection_WhenNameUniqueConstraintIsViolated()
        {
            // Arrange
            SourceFormat sourceFormat = new SourceFormat
            {
                Name = "name",
                Desc = "desc",
                IsActive = 1,
            };

            SourceFormat result = await masterDataBusinessLogic.AddSourceFormatAsync(
                sourceFormat).ConfigureAwait(false);

            // Act
            Func<Task> action = async () =>
            {
                await masterDataBusinessLogic.AddSourceFormatAsync(sourceFormat).ConfigureAwait(false);
            };

            // Assert
            action.Should().ThrowExactly<MasterDataBusinessLogicAddSourceFormatAsyncOperationException>();
        }
    }
}