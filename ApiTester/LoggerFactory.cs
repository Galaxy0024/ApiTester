using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTester
{
    class LoggerFactory
    {
        /// <summary>
        /// Gets a Logger instance based on the enum element
        /// I decided to use the factory design pattern,
        /// since logging is usually done in databases.
        /// Currently the client only requested csv and console
        /// logging, but with a factory I can add database logging
        /// easily.
        /// </summary>
        /// <param name="loggerType"></param>
        /// <returns></returns>
        public ILogger GetLoggerInstance(Methods.LoggerTypes loggerType)
        {
            switch (loggerType)
            {
                case Methods.LoggerTypes.CsvLogger:
                    return new CsvLogger();
                case Methods.LoggerTypes.ConsoleLogger:
                    return new ConsoleLogger();                    
                default:
                    throw new Exception("Invalid Logger type");
            }
        }
    }
}
