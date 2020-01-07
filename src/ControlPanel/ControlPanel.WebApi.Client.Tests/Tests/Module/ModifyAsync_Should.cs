namespace DigitalLibrary.IaC.ControlPanel.WebApi.Client.Tests.Tests.Module
{
    using System;
    using System.Threading.Tasks;

    using Client.Menu.Exceptions;

    using FluentAssertions;

    using Xunit;

    public class ModifyAsync_Should : TestBase
    {
        [Trait("Category", "Unit")]
        public async Task Throw_ArgumentNullException_WhenInputIsNull()
        {
            // Arrange

            // Act
            Func<Task> action = async () =>
            {
                await ControlPanelWebApiClient
                    .ModifyModuleAsync(null).ConfigureAwait(false);
            };

            // Assert
            action.Should().ThrowExactly<ControlPanelWebApiClientModifyModuleAsyncOperationException>();
        }
    }
}