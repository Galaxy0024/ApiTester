using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ApiTester
{
    class Program
    {
        /// <summary>
        /// Asynchronous main function
        /// Sends a get request, then logs the result using the specific logger.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
           //Methods.MainAsync(args).GetAwaiter().GetResult();
            CryptoCurrency result = await Methods.GetCryptoAsync(ConfigurationManager.AppSettings["cryptoApiRequest"]);
            LoggerFactory loggerFactory = new LoggerFactory();
            ILogger logger = loggerFactory.GetLoggerInstance(Methods.LoggerTypes.ConsoleLogger);

            logger.Log(result);
        }
    }
}
