namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.StepDefinitions
{
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.DomainModel;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    public partial class StepDefinitions
    {
        [Given(@"SourceFormat is requested with active DimensionStructure tree")]
        public async Task SourceFormatIsRequestedWithActiveDimensionStructureTree(Table table)
        {
            SourceFormatIsRequestedWithActiveDimensionStructureTreeEntity instance = table
               .CreateInstance<SourceFormatIsRequestedWithActiveDimensionStructureTreeEntity>();

            SourceFormat sourceFormat = _scenarioContext[instance.SourceFormatKey] as SourceFormat;

            SourceFormat result = await _masterDataBusinessLogic.MasterDataSourceFormatBusinessLogic
               .GetSourceFormatByIdWithActiveDimensionStructureTreeAsync(sourceFormat.Id)
               .ConfigureAwait(false);

            _scenarioContext.Add(instance.ResultKey, result);
        }
    }

    internal class SourceFormatIsRequestedWithActiveDimensionStructureTreeEntity
    {
        public string SourceFormatKey { get; set; }

        public string ResultKey { get; set; }
    }
}