using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class StockManagement
    {
        public void AccountManagment()
        {
            int totalshares = 0;
            string filepath = "E:\\RFP 215\\StockAccountManagement\\StockAccountmanagement_usingJSON\\StockAccountManagement\\StockDetails.json";
            string record = File.ReadAllText(filepath);
            StockUtility data = JsonConvert.DeserializeObject<StockUtility>(record);
            List<StockDetails> stockdetails = data.stockDetails;
            foreach (StockDetails i in stockdetails)
            {
                Console.WriteLine("Stock name : {0} \n No of Shares : {1} \n Stock Price : {2} ", i.StockName, i.NoOfShares, i.StockPrice);
                int total = i.NoOfShares * i.StockPrice;
                totalshares += total;
                Console.WriteLine("==> Total stock price for {0} is : {1}", i.StockName, total);

            }
            Console.WriteLine("Total stares of all stocks is : " + totalshares);
        }
    }
}
