using Microsoft.Extensions.Hosting;
using ProjektTestowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorProject
{
    [Binding]
    public sealed class Hooks
    {
        private static IHost _host;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _host = Program.CreateHostBuilder(null).Build();
            _host.Start();

        }

        [AfterTestRun]
        public static void AfterTestRun()

        {
           _host.StopAsync().Wait();
        }
    }
}
