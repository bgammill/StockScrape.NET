using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScraper.NET
{
    class Nyse : IExchange
    {
        public List<Stock> GetStocks()
        {
            return new List<Stock>();
        }

        public void WriteStockFile()
        {

        }
    }
}
