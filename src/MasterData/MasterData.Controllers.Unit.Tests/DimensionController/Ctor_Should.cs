namespace DigitalLibrary.MasterData.Controllers.Unit.Tests.DimensionController
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Utils.Guards;

    using Xunit;

    [ExcludeFromCodeCoverage]
    public class Ctor_Should
    {
        [Fact]
        public void ThrowException_WhenInputIsNull()
        {
            // Arrange

            // Act
            Func<Task> action = async () => { new Controllers.DimensionController(null); };

            // Assert
            action.Should().ThrowExactly<GuardException>();
        }
    }
}