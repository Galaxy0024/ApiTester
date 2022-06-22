using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;

namespace ApiTester
{
    class CsvLogger : ILogger
    {
        public void Log(CryptoCurrency cryptoCurrency)
        {
            StreamWriter streamWriter = new StreamWriter(ConfigurationManager.AppSettings["csvLogPath"], append: true);
            streamWriter.WriteLine("{0};{1};", cryptoCurrency.Uid, cryptoCurrency.Md5);

            streamWriter.Close();

        }
    }
}
