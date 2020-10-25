namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.StepDefinitions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.DomainModel;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    public partial class StepDefinitions
    {
        [When(@"I query active SourceFormats")]
        public async Task WhenIQueryActiveSourceFormats(Table table)
        {
            WhenIQueryActiveSourceFormatsEntity instance = table
               .CreateInstance<WhenIQueryActiveSourceFormatsEntity>();

            List<SourceFormat> actives = await _masterDataBusinessLogic.MasterDataSourceFormatBusinessLogic
               .GetActivesAsync()
               .ConfigureAwait(false);

            _scenarioContext.Add(instance.ResultKey, actives);
        }
    }

    internal class WhenIQueryActiveSourceFormatsEntity
    {
        public string ResultKey { get; set; }
    }
}