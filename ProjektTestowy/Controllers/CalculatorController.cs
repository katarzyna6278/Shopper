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


        [HttpGet("/Calculator/Add")]
        public int Add(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            return _calculator.Add();
        }

        [HttpGet("/Calculator/Subtract")]
        public int Subtract(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            return _calculator.Subtract();
        }

        [HttpGet("/Calculator/Multiply")]
        public int Multiply(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            return _calculator.Multiply();
        }

        [HttpGet("/Calculator/Divide")]
        public int Divide(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            return _calculator.Divide();
        }
    }   
}
