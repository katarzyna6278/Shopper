using ProjektTestowy;

namespace SpecFlowCalculatorProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("first number is 1")]
        public void GivenTheFirstNumberIs()
        {
            _calculator.FirstNumber = 1;
        }

        [Given("second number is 2")]
        public void GivenTheSecondNumberIs()
        {
            _calculator.SecondNumber = 2;
        }

        [When("two numbers are added")]
        public void WhenNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result is 3")]
        public void ThenTheResultIs()
        {
            _result.Should().Be(3);
        }
    }
}
