namespace DigitalLibrary.MasterData.Controllers.Integration.Tests.SourceFormat
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using DomainModel;

    using FluentAssertions;

    using Utils.IntegrationTestFactories.Factories;

    using WebApp;

    using Xunit;
    using Xunit.Abstractions;

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "CA1707")]
    [Collection("DigitalLibrary.IaC.MasterData.Controllers.Integration.Tests")]
    public class Update_SourceFormat_NameDescIsActive_Should : TestBase<SourceFormat>
    {
        public Update_SourceFormat_NameDescIsActive_Should(
            DiLibMasterDataWebApplicationFactory<Startup, SourceFormat> host,
            ITestOutputHelper testOutputHelper) : base(host, testOutputHelper)
        {
        }

        [Fact]
        public async Task Update_NameDescIsActive()
        {
            // Arrange
            string name = "name";
            string desc = "desc";
            int isActive = 0;

            SourceFormat orig = new SourceFormat
            {
                Name = "orig",
                Desc = "orig",
                IsActive = 1
            };
            SourceFormat origResult = await _masterDataHttpClient
               .AddSourceFormatAsync(orig)
               .ConfigureAwait(false);

            origResult.Name = name;
            origResult.Desc = desc;
            origResult.IsActive = isActive;

            // Act
            SourceFormat result = await _masterDataHttpClient
               .UpdateSourceFormatAsync(origResult)
               .ConfigureAwait(false);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(origResult.Id);
            result.Name.Should().Be(name);
            result.Desc.Should().Be(desc);
            result.IsActive.Should().Be(isActive);
        }
    }
}