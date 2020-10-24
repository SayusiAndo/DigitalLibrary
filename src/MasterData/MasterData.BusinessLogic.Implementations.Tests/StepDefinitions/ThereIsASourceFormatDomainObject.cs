namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.StepDefinitions
{
    using DigitalLibrary.Utils.MasterDataTestHelper.Tools;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    public partial class StepDefinitions
    {
        [Given(@"there is a SourceFormat domain object")]
        public void ThereIsASourceFormatDomainObject(Table table)
        {
            ThereIsASourceFormatDomainObjectEntity instance = table
               .CreateInstance<ThereIsASourceFormatDomainObjectEntity>();

            DomainModel.SourceFormat sourceFormat = _masterDataTestHelper
               .SourceFormatFactory
               .Create(instance);

            if (string.IsNullOrEmpty(instance.Key) || string.IsNullOrWhiteSpace(instance.Key))
            {
                string msg = $"Key is empty or null";
                throw new MasterDataStepDefinitionException(msg);
            }

            _scenarioContext.Add(instance.Key, sourceFormat);
        }
    }

    internal class ThereIsASourceFormatDomainObjectEntity : ISourceFormatDomainObject
    {
        public string Desc { get; set; }

        public int IsActive { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }
    }
}