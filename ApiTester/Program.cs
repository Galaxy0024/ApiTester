using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ApiTester
{
    class Program
    {
        static void Main(string[] args)
        {
           Methods.MainAsync(args).GetAwaiter().GetResult();
        }
    }
}
