using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "http://faculty.css.edu/tgibbons/trades4.txt";

            var tradeProcessor = new TradeProcessor();
            tradeProcessor.ProcessTradesFromWeb(URL);

            Console.ReadKey();
        }
    }
}
