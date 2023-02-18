using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class StockDetails
    {
        public string StockName { get; set; }
        public int NoOfShares { get; set; }
        public int StockPrice { get; set; }
        
    }
    public class StockUtility
    {
        public List<StockDetails> stockDetails { get; set; }
    }
    
}
