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
        /// Sends an asynchronous GET request to the API, then saves the response in a CryptoCurrency object
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static async Task<CryptoCurrency> GetCryptoAsync(string path)
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
