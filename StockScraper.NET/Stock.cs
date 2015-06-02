using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockScraper.NET
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public object LastSale { get; set; }
        public string MarketCap { get; set; }
        public object IPOyear { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public string Summary { get; set; }
    }
}
