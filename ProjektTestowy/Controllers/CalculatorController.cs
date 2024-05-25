using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTestowy.Controllers
{
    //atrybuty controllera
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;


        //konstruktor
        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        //endpoint
        [HttpGet("/Calculator/Add")]
        public int Add(int firstNumer, int secondNumber)
        {
            _calculator.FirstNumber = firstNumer;
            _calculator.SecondNumber = secondNumber;

            var result = _calculator.Add();

            return result;
        }
        //endpoint do odejmowania
        [HttpGet("/Calculator/Substract")]

        public int Substract(int firstNumber, int secondNumber)
        {
            _calculator.FirstNumber = firstNumber;
            _calculator.SecondNumber = secondNumber;

            var result = _calculator.Subtract();

            return result;
        }
    }
}
