namespace DigitalLibrary.IaC.ControlPanel.WebApi.Client.Tests.Tests.Menu
{
    using System;
    using System.Threading.Tasks;

    using Client.Menu.Exceptions;

    using FluentAssertions;

    using Xunit;

    public class AddAsync_Should : TestBase
    {
        [Trait("Category", "Unit")]
        public async Task Throw_ArgumentNullException_WhenInputIsNull()
        {
            // Arrange

            // Act
            Func<Task> action = async () =>
            {
                await ControlPanelWebApiClient
                    .AddMenuAsync(null).ConfigureAwait(false);
            };

            // Arrange
            action.Should().ThrowExactly<ControlPanelWebApiClientAddMenuAsyncOperationException>();
        }
    }
}