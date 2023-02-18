using System;
namespace StockAccountManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  *****  Stock account management  *****");
            StockManagement stock=new StockManagement();
            stock.AccountManagment();
        }
    }
}