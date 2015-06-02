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
            Initialize();
            LoadStocks();
            WriteStocks();
        }

        public static void Initialize()
        {
            exchanges = new List<IExchange>()
            {
                new Nasdaq(),
                new Nyse()
            };
        }

        public static void LoadStocks()
        {
            exchanges.ForEach(x => x.LoadStocks());
        }

        public static void WriteStocks()
        {
            exchanges.ForEach(x => x.WriteStocks());
        }
    }
}
