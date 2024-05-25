using System.Net;
using RestSharp;

namespace SpecFlowCalculatorProject.API
{
    public class CalculatorApi
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        private readonly RestClient _client; // komentowanie CTRL + K + C

        public CalculatorApi()
        {
            _client = new RestClient("http://localhost:5001");

            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
        }

        public async Task<int> AddAsync()
        {
            var request = new RestRequest("Calculator/Add").AddObject(this);

            var response = await _client.GetAsync<int>(request);

            return response;
        }
    }
}
