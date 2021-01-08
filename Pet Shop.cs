using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsNumber = int.Parse(Console.ReadLine());
            int otherDogsNumber = int.Parse(Console.ReadLine());

            double costsDodsFood = dogsNumber * 2.50;
            double costsotherDogsFood = otherDogsNumber * 4.00;

            double endSum = costsDodsFood + costsotherDogsFood;

            Console.WriteLine("{0:F2} lv.", endSum);

        }
    }
}
