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
        public Nasdaq()
        {

        }

        public List<Stock> GetStocks()
        {
            var contents = File.ReadAllText("symbols.json");
            return JsonConvert.DeserializeObject<List<Stock>>(contents);
        }

        public void WriteStockFile()
        {
            throw new NotImplementedException();
        }
    }
}
