using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTester
{
    abstract class Currency
    {
        public string Uid { get; set; }

        protected Currency(string uid)
        {
            this.Uid = uid;
        }

        public virtual void DoSomething()
        {
            Console.WriteLine("Default behavior");
        }

        public abstract string GetData();
    }
}
