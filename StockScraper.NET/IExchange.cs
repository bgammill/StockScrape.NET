using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScraper.NET
{
    public interface IExchange
    {
        void GetStocks();

        void WriteStockFile();
    }
}
