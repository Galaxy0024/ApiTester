using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ApiTester
{
    static class Methods
    {
        public enum LoggerTypes
        {
            CsvLogger,
            ConsoleLogger
        }

        private static HttpClient client = new HttpClient();

        /// <summary>
        /// Asynchronous main function
        /// Sends a get request, then logs the result using the specific logger.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task MainAsync(string[] args)
        {
            CryptoCurrency result = await GetCryptoAsync(ConfigurationManager.AppSettings["cryptoApiRequest"]);
            LoggerFactory loggerFactory = new LoggerFactory();
            ILogger logger = loggerFactory.GetLoggerInstance(LoggerTypes.CsvLogger);

            logger.Log(result);
        }

        /// <summary>
        /// Sends an asynchronous GET request to the API, then saves the response in a CryptoCurrency object
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static async Task<CryptoCurrency> GetCryptoAsync(string path)
        {
            CryptoCurrency cryptoCurrency = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                cryptoCurrency = await response.Content.ReadAsAsync<CryptoCurrency>();
            }
            return cryptoCurrency;
        }
    }
}
