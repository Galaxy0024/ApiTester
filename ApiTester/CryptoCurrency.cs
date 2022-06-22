﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTester
{
    class CryptoCurrency : Currency
    {

        private string md5;

        public string Md5
        { get; set; }

        private string sha1;

        public string Sha1
        { get; set; }

        private string sha256;

        public string Sha256
        { get; set; }

        public CryptoCurrency(string uid, string md5, string sha1, string sha256) : base(uid)
        {
            this.md5 = md5;
            this.sha1 = sha1;
            this.sha256 = sha256;
        }


        public override string GetData()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat("Uid: {0}", this.Uid).AppendLine();
            stringBuilder.AppendFormat("MD5: {0}", this.Md5).AppendLine();

            return stringBuilder.ToString();
        }


        public override void DoSomething()
        {
            Console.WriteLine("This is a CryptoCurrency");
        }
    }
}
