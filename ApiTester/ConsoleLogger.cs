using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTester
{
    class ConsoleLogger : ILogger
    {
        public void Log(CryptoCurrency cryptoCurrency)
        {
            Console.WriteLine(cryptoCurrency.GetData());
        }
    }
}
