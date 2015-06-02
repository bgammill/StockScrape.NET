using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScrape.NET
{
    class Program
    {
        static List<IExchange> exchanges;

        static void Main(string[] args)
        {
            exchanges = new List<IExchange>()
            {
                new Nasdaq(),
                new Nyse()
            };

            exchanges.ForEach(x => x.GetStocks());
        }
    }
}
