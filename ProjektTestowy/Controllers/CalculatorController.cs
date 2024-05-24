using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Add(int firstNumer, int secondNumber)
        {
            _calculator.FirstNumber = firstNumer;
            _calculator.SecondNumber = secondNumber;

            return _calculator.Add();
        }
    }
}
