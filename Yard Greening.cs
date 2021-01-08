using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());


            double totalCosts = squareMeters * 7.61;
            double discount = totalCosts * 0.18;
            double endPrice = totalCosts - discount;


            Console.WriteLine("The final price is: {0:F2} lv.", endPrice);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);

        }
    }
}
