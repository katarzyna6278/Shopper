using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorProject
{
    public class CalculatorApi
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        private readonly RestClient _client; // komentowanie CTRL + K + C

        public CalculatorApi() 
        {  
            _client = new RestClient("https://localhost:5001");
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
        }

        public sealed class CalculatorResponse
        {
            public int Result { get; set; }
        }

        public async Task<int> AddAsync()
        {
            var request = new RestRequest("Calculator/Add").AddObject(this);

            var response = await _client.GetAsync<int>(request);

            return response; 
  
        }

    }
}
