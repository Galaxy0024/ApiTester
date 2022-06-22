using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTester
{
    abstract class Currency
    {
        private string uid;

        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        protected Currency(string uid)
        {
            this.uid = uid;
        }

        public virtual void DoSomething()
        {
            Console.WriteLine("Default behavior");
        }

        public abstract string GetData();
    }
}
