using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9.FinalTask1
{
    public class MyCompanyEx : Exception
    {
        public MyCompanyEx(string message) : this (message, string.Empty) { }

        //public MyCompanyEx(string message, Dictionary<string, object>[] data) : this (message, data, string.Empty)  { }

        public MyCompanyEx(string message, string helpLink) : base(message)
        {
            this.Data.Add("ExceptionDate", DateTime.Now);
            HelpLink = helpLink;
            //Data.Add(data);
        }
    }
}
