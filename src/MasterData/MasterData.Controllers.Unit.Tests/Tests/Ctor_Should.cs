namespace DigitalLibrary.MasterData.Controllers.Unit.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Utils.Guards;

    using Xunit;

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "CA1707")]
    [SuppressMessage("ReSharper", "CA1806")]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public class Ctor_Should
    {
        [Fact]
        public void ThrowException_WhenInputIsNull()
        {
            // Arrange

            // Act
            Action action = () => { new SourceFormatController(null); };

            // Assert
            action.Should().ThrowExactly<GuardException>();
        }
    }
}