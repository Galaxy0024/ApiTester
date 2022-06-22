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
            ApiClient apiClient = ApiClient.Instance;

            CryptoCurrency result = await apiClient.GetCryptoAsync(ConfigurationManager.AppSettings["cryptoApiRequest"]);

            LoggerFactory loggerFactory = new LoggerFactory();
            ILogger logger = loggerFactory.GetLoggerInstance(ApiClient.LoggerTypes.ConsoleLogger);

            logger.Log(result);
        }
    }
}
