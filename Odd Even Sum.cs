using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = 0;
            int evenPositionSum = 0;
            int oddPositionSum = 0;

            for (int i = 0; i < input; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenPositionSum += number;
                }
                else
                {
                    oddPositionSum += number;
                }
            }

            if (evenPositionSum == oddPositionSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenPositionSum);
            }
            else
            {
                int diff = Math.Abs(evenPositionSum - oddPositionSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }

        }
    }
}
