namespace DigitalLibrary.MasterData.BusinessLogic.Features.StepDefinitions
{
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.DomainModel;
    using DigitalLibrary.Utils.Guards;
    using DigitalLibrary.Utils.MasterDataTestHelper.Entities;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    public partial class StepDefinitions
    {
        [Given(@"there is a SourceFormatDimensionStructureNode domain object")]
        public async Task ThereIsASourceFormatDimensionStructureNodeDomainObject(Table table)
        {
            ThereIsASourceFormatDimensionStructureNodeDomainObjectEntity instance = table
               .CreateInstance<ThereIsASourceFormatDimensionStructureNodeDomainObjectEntity>();
            
            SourceFormatDimensionStructureNode result = new SourceFormatDimensionStructureNode();

            if (instance.SourceFormatKey != null)
            {
                SourceFormat sourceFormat = _scenarioContext[instance.SourceFormatKey] as SourceFormat;
                Check.IsNotNull(sourceFormat);
                result.SourceFormat = sourceFormat;
                result.SourceFormatId = sourceFormat.Id;
            }

            if (instance.DimensionStructureNodeKey != null)
            {
                DimensionStructureNode dimensionStructureNode = _scenarioContext[instance.DimensionStructureNodeKey]
                    as DimensionStructureNode;
                Check.IsNotNull(dimensionStructureNode);
                result.DimensionStructureNode = dimensionStructureNode;
                result.DimensionStructureNodeId = dimensionStructureNode.Id;
            }
            
            SourceFormatDimensionStructureNode node = await _masterDataBusinessLogic
               .MasterDataSourceFormatDimensionStructureNodeBusinessLogic
               .AddAsync(result)
               .ConfigureAwait(false);
            
            _scenarioContext.Add(instance.ResultKey, node);
        }
    }

    internal class ThereIsASourceFormatDimensionStructureNodeDomainObjectEntity
    {
        public string ResultKey { get; set; }

        public string SourceFormatKey { get; set; }

        public string DimensionStructureNodeKey { get; set; }
    }
}