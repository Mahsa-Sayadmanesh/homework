using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    public class Program {
        static void Main(string[] args) {

            Console.WriteLine("Input the nominal of the trade:");
            double Nominal = double.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine("Give the transaction type:");
            string userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);
            int Sign = (trcType == TransactionType.Sell) ? -1 : 1;
            Console.WriteLine("Enter security price:");
            double Price = double.Parse(Console.ReadLine());
            double CurrentValue = Sign * Price * Nominal;
            Console.WriteLine($"Here is the details of your trade:\n Nominal: {Nominal}\n Price: {Price}\n Transaction:{trcType}\nCurrent Value:{CurrentValue}");
            //Assignment 2
            Console.WriteLine("Enter the original price of this instrument:");
            double OriginalPrice = double.Parse(Console.ReadLine());
            double ProfitLoss = trcType == TransactionType.Buy ? 0 : (Price - OriginalPrice) * Nominal;
            Console.WriteLine($"Calculated Profit/loss is:{ ProfitLoss}");
            Console.ReadKey();


        }
    }
}
