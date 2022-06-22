using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ApiTester
{
    /// <summary>
    /// ApiClient class - this class is responsible for the api functions
    /// It's done using the Singleton design pattern, since we want to ensure,
    /// it's only instantiated once 
    /// </summary>
    sealed class ApiClient : IApiClient
    {
        public enum LoggerTypes
        {
            CsvLogger,
            ConsoleLogger
        }

        private HttpClient httpClient;

        private static ApiClient instance = null;

        private ApiClient()
        {
             this.httpClient = new HttpClient();
        }

        public static ApiClient Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ApiClient();
                }
                return instance;
            }
        }

        /// <summary>
        /// Sends an asynchronous GET request to the API, then saves the response in a CryptoCurrency object
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public async Task<CryptoCurrency> GetCryptoAsync(string path)
        {
            CryptoCurrency cryptoCurrency = null;
            HttpResponseMessage response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                cryptoCurrency = await response.Content.ReadAsAsync<CryptoCurrency>();
            }
            return cryptoCurrency;
        }
    }
}
