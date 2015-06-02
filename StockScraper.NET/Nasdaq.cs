using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScraper.NET
{
    class Nasdaq : IExchange
    {
        Dictionary<string, Stock> stocks;

        public Nasdaq()
        {
            stocks = new Dictionary<string, Stock>();
        }

        public void GetStocks()
        {
            var contents = File.ReadAllText("symbols.json");
            var result = JsonConvert.DeserializeObject<List<Stock>>(contents);
            result.ForEach(x => stocks.Add(x.Symbol, x));
        }

        public void WriteStockFile()
        {
            throw new NotImplementedException();
        }
    }
}
