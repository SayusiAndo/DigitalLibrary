namespace DigitalLibrary.IaC.MasterData.Controllers.Integration.Tests.Tests.DimensionStructure
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;

    using DomainModel.DomainModel;

    using FluentAssertions;

    using QA.Integration.Tests.Factories;

    using WebApp;

    using Xunit;
    using Xunit.Abstractions;

    [ExcludeFromCodeCoverage]
    [Collection("DigitalLibrary.IaC.MasterData.Controllers.Integration.Tests")]
    public class Get_Should : TestBase<DimensionStructure>
    {
        public Get_Should(DiLibMasterDataWebApplicationFactory<Startup, DimensionStructure> host,
                          ITestOutputHelper testOutputHelper) : base(host, testOutputHelper)
        {
        }

        [Fact]
        public async Task Return_All()
        {
            // Arrange
            DimensionStructure topDimensionStructure = new DimensionStructure
            {
                Name = "name",
                Desc = "desc",
                IsActive = 1
            };
            DimensionStructure topDimensionStructureResult = await masterDataHttpClient
                .AddTopDimensionStructureAsync(topDimensionStructure)
                .ConfigureAwait(false);

            DimensionStructure dimensionStructure1 = new DimensionStructure
            {
                Name = "list1",
                Desc = "list1",
                IsActive = 1,
                ParentDimensionStructureId = topDimensionStructureResult.Id
            };
            DimensionStructure dimensionStructure1Result = await masterDataHttpClient
                .AddDimensionStructureAsync(dimensionStructure1)
                .ConfigureAwait(false);

            DimensionStructure dimensionStructure2 = new DimensionStructure
            {
                Name = "list2",
                Desc = "list2",
                IsActive = 1,
                ParentDimensionStructureId = topDimensionStructureResult.Id
            };
            DimensionStructure dimensionStructure2Result = await masterDataHttpClient
                .AddDimensionStructureAsync(dimensionStructure2)
                .ConfigureAwait(false);

            DimensionStructure dimensionStructure3 = new DimensionStructure
            {
                Name = "list3",
                Desc = "list3",
                IsActive = 1,
                ParentDimensionStructureId = topDimensionStructureResult.Id
            };
            DimensionStructure dimensionStructure3Result = await masterDataHttpClient
                .AddDimensionStructureAsync(dimensionStructure3)
                .ConfigureAwait(false);

            // Act
            List<DimensionStructure> dimensionStructures = await masterDataHttpClient.GetDimensionStructuresAsync()
                .ConfigureAwait(false);

            // Assert
            dimensionStructures.Should().NotBeNull();
            dimensionStructures.Count.Should().Be(3);
            dimensionStructures.Count(n => n.Name == dimensionStructure1.Name).Should().Be(1);
            dimensionStructures.Count(n => n.Name == dimensionStructure2.Name).Should().Be(1);
            dimensionStructures.Count(n => n.Name == dimensionStructure3.Name).Should().Be(1);
        }
    }
}