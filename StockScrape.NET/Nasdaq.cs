using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScrape.NET
{
    class Nasdaq : IExchange
    {
        Dictionary<string, Stock> stocks;

        public Nasdaq()
        {
            stocks = new Dictionary<string, Stock>();
        }

        public void LoadStocks()
        {
            var contents = File.ReadAllText("symbols.json");
            var result = JsonConvert.DeserializeObject<List<Stock>>(contents);
            result.ForEach(x => stocks.Add(x.Symbol, x));
        }

        public void WriteStocks()
        {
            using (var writer = new StreamWriter("scraped.csv", false))
            {
                foreach (var key in stocks.Keys)
                {
                    var output = string.Format("{0},{1}", key, stocks[key].LastSale);
                    writer.WriteLine(output);
                }
                writer.Close();
            }
        }
    }
}
