using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());

            int totalToys = puzzles + dolls + bears + minions + tracks;
            double totalPrice = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + tracks * 2;

            if (totalToys >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }

            totalPrice = totalPrice * 0.90;

            if (totalPrice >= vacation)
            {
                double surpluse = totalPrice - vacation;
                Console.WriteLine("Yes! {0:f2} lv left.", surpluse);
            }
            else
            {
                double deficit = vacation - totalPrice;
                Console.WriteLine("Not enough money! {0:f2} lv needed.", deficit);
            }

        }
    }
}
