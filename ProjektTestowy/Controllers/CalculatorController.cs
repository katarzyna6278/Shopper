using Microsoft.AspNetCore.Mvc;

namespace ProjektTestowy.Controllers
{
    // atrybuty controllera
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        // konstruktor
        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        // endpoint
        [HttpGet("/Calculator/Add")]
        public int Add(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            var result = _calculator.Add();

            return result;
        }

        // do zrobienia endpoint do odejmowania

        [HttpGet("/Calculator/Substract")]
        public int Subtract(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            var result = _calculator.Subtract();
            return result;
        }
    }
}
