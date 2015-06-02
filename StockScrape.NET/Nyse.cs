using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScrape.NET
{
    class Nyse : IExchange
    {
        Dictionary<string, Stock> stocks;

        public Nyse()
        {
            stocks = new Dictionary<string, Stock>();
        }

        public void GetStocks()
        {

        }

        public void WriteStockFile()
        {

        }
    }
}
