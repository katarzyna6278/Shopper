using ProjektTestowy;
using SpecFlowCalculatorProject.API;

namespace SpecFlowCalculatorProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private readonly CalculatorApi _calculatorApi = new CalculatorApi();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _calculator.FirstNumber = firstNumber;
        }

        [Given("second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            _calculator.SecondNumber = secondNumber;
        }

        [When("two numbers are added")]
        public void WhenNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        // Wspólny krok do sprawdzania 
        [Then("the result is (.*)")]
        public void ThenTheResultIs(int thirdNumber)
        {
            _result.Should().Be(thirdNumber);
        }

        [When("two numbers are subtracted")]
        public void WhenTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When(@"two numbers are multiply")]
        public void WhenTwoNumbersAreMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When(@"two numbers are divided")]
        public void WhenTwoNumbersAreDivided()
        {
            _result = _calculator.Divide();
        }

        // Kroki do sprawdzania Api
        [Given("first api number is (.*)")]
        public void GivenTheFirstNumberIsByApi(int firstNumber)
        {
            _calculatorApi.FirstNumber = firstNumber;
        }

        [Given("second api number is (.*)")]
        public void GivenTheSecondNumberIsByApi(int secondNumber)
        {
            _calculatorApi.SecondNumber = secondNumber;
        }

        [When("two numbers are added by Api")]
        public async Task WhenNumbersAreAddedByApi()
        {
            _result = await _calculatorApi.AddAsync();
        }
    }
}

