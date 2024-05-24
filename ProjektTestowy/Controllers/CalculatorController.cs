using Microsoft.AspNetCore.Mvc;

namespace ProjektTestowy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;
        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        [HttpGet("/Calculator/Add")]
        public int Add(int firstNumber, int secondNumber)
        { 
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            return _calculator.Add();
        }
    }
}