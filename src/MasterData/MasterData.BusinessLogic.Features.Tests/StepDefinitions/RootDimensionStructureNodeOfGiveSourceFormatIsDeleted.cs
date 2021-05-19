namespace DigitalLibrary.MasterData.BusinessLogic.Features.Tests.StepDefinitions
{
    using System;
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.DomainModel;
    using DigitalLibrary.Utils.Guards;
    using DigitalLibrary.Utils.MasterDataTestHelper.Entities;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    public partial class StepDefinitions
    {
        [When(@"root DimensionStructureNode of give SourceFormat is deleted")]
        public async Task WhenRootDimensionStructureNodeOfGiveSourceFormatIsDeleted(Table table)
        {
            KeyResultKeyEntity instance = table.CreateInstance<KeyResultKeyEntity>();

            SourceFormat sourceFormat = _scenarioContext[instance.Key] as SourceFormat;
            Check.IsNotNull(sourceFormat);

            try
            {
                await _masterDataBusinessLogic.MasterDataDimensionStructureNodeBusinessLogic
                   .DeleteRootDimensionStructureNodeOfSourceFormatAsync(sourceFormat)
                   .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
