namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.stepdefs
{
    using DigitalLibrary.Utils.Guards;

    using FluentAssertions;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    public partial class StepDefs
    {
        [Then(@"difference between lists is")]
        public void DifferenceBetweenActiveAmountBeforeLogicalDeleteAndAfterIs(Table table)
        {
            Check.IsNotNull(table);
            var instance = table.CreateInstance<(int expectedDiff,
                string firstResultKey,
                string secondResultKey)>();

            int amountBefore = (int) _scenarioContext[instance.firstResultKey];
            int amountAfter = (int) _scenarioContext[instance.secondResultKey];

            int result = amountBefore - amountAfter;
            result.Should().Be(instance.expectedDiff);
        }
    }
}