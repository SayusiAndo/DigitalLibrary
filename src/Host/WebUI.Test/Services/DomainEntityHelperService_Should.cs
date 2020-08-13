// Digital Library project
// https://github.com/SayusiAndo/DigitalLibrary
// Licensed under MIT License

namespace DigitalLibrary.Ui.WebUI.Test.Services
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using FluentAssertions;

    using MasterData.DomainModel;

    using WebUi.Services;

    using Xunit;

    [SuppressMessage("ReSharper", "CA1707")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [ExcludeFromCodeCoverage]
    public class DomainEntityHelperService_Should
    {
        [Fact]
        // ReSharper disable once IdentifierTypo
        public async Task AddNullo_ToTheList()
        {
            IDomainEntityHelperService service = new DomainEntityHelperService();

            List<Dimension> list = new List<Dimension>
            {
                new Dimension(),
                new Dimension(),
                new Dimension()
            };

            List<Dimension> result = await service.AddNulloToListAsFirstItem(list)
               .ConfigureAwait(false);

            result.Count.Should().Be(4);
        }
    }
}