// Konner Marak 113423502



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTotal_Konner_Marak
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxRate = 0.085;
            Console.WriteLine("What is the name of the product you are purchasing?");
           string product = Console.ReadLine();

            Console.WriteLine("How many " + product + " do you want to buy?");
               int productAmount = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is the price for each " + product + "?");
            double price = Convert.ToDouble(Console.ReadLine());
            double subTotal = price * productAmount;
            double salesTax = price * productAmount * taxRate;
            double total = subTotal + salesTax;
            string subTotalAsstring = subTotal.ToString("C2");
            string salesTaxAsstring = salesTax.ToString("C2");
            string totalAsstring = total.ToString("C2");


            Console.WriteLine("Your subtotal for your bill is " + subTotalAsstring);
            Console.WriteLine("Your sales tax for your bill is " + salesTaxAsstring);
            Console.WriteLine("Your total for your bill is " +totalAsstring );


            
            Console.ReadKey();
       
        }
    }
}
