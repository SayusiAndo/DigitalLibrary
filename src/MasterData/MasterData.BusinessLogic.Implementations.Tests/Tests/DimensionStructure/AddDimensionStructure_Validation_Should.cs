using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

using DigitalLibrary.MasterData.Validators.TestData.TestData;

using FluentAssertions;

using FluentValidation;

using Xunit;

namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.Tests.DimensionStructure
{
    using Exceptions;

    [ExcludeFromCodeCoverage]
    public class AddDimensionStructure_Validation_Should : TestBase
    {
        private const string TestInfo = nameof(AddDimensionStructure_Validation_Should);

        public AddDimensionStructure_Validation_Should() : base(TestInfo)
        {
        }

        [Fact]
        public async Task ThrowException_WhenInputIsNull()
        {
            // Arrange

            // Act
            Func<Task> action = async () =>
            {
                await masterDataBusinessLogic.AddDimensionStructureAsync(null).ConfigureAwait(false);
            };

            // Assert
            action.Should().ThrowExactly<MasterDataBusinessLogicAddDimensionStructureAsyncOperationException>()
               .WithInnerException<MasterDataBusinessLogicArgumentNullException>();
        }

        [Theory]
        [MemberData(nameof(MasterData_DimensionStructure_TestData.AddDimensionStructure_Validation_TestData),
            MemberType = typeof(MasterData_DimensionStructure_TestData))]
        public async Task ThrowException_WhenInputIsInvalid(
            long id,
            string name,
            string desc,
            int isActive,
            long parentId)
        {
            // Arrange
            DomainModel.DomainModel.DimensionStructure dimensionStructure =
                new DomainModel.DomainModel.DimensionStructure
                {
                    Id = id,
                    ParentDimensionStructureId = parentId,
                    Name = name,
                    Desc = desc,
                    IsActive = isActive
                };

            // Act
            Func<Task> action = async () =>
            {
                await masterDataBusinessLogic.AddDimensionStructureAsync(dimensionStructure).ConfigureAwait(false);
            };

            // Assert
            action.Should().ThrowExactly<MasterDataBusinessLogicAddDimensionStructureAsyncOperationException>()
               .WithInnerException<ValidationException>();
        }
    }
}