using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int moneyTotal = 0;


            for (int i = 1; i <= age; i++)
            {


                if (i % 2 == 0)
                {
                    money += 10;
                    moneyTotal += money - 1;
                }
                else
                {
                    toys++;
                }
            }

            moneyTotal += toys * toyPrice;


            double diff = Math.Abs(moneyTotal - priceWM);

            if (moneyTotal >= priceWM)
            {
                Console.WriteLine("Yes! {0:f2}", diff);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", diff);
            }
        }
    }
}
