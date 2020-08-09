namespace DigitalLibrary.MasterData.Controllers.Integration.Tests.SourceFormat
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using DomainModel;

    using FluentAssertions;

    using Utils.IntegrationTestFactories.Factories;

    using WebApi.Client;

    using WebApp;

    using Xunit;
    using Xunit.Abstractions;

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "CA1707")]
    [Collection("DigitalLibrary.IaC.MasterData.Controllers.Integration.Tests")]
    public class Delete_SourceFormat_Validation_Should : TestBase<SourceFormat>
    {
        public Delete_SourceFormat_Validation_Should(
            DiLibMasterDataWebApplicationFactory<Startup, SourceFormat> host,
            ITestOutputHelper testOutputHelper) : base(host, testOutputHelper)
        {
        }

        [Fact]
        public void ThrowException_WhenInputIsInvalid()
        {
            // Arrange
            SourceFormat sourceFormat = new SourceFormat
            {
                Id = 0
            };

            // Act
            Func<Task> action = async () =>
            {
                await _masterDataHttpClient.DeleteSourceFormatAsync(sourceFormat)
                   .ConfigureAwait(false);
            };

            // Assert
            action.Should().ThrowExactly<MasterDataHttpClientException>();
        }

        [Fact]
        public void ThrowException_WhenInputIsNull()
        {
            // Arrange

            // Act
            Func<Task> action = async () =>
            {
                await _masterDataHttpClient.DeleteSourceFormatAsync(null)
                   .ConfigureAwait(false);
            };

            // Assert
            action.Should().ThrowExactly<MasterDataHttpClientException>();
        }
    }
}