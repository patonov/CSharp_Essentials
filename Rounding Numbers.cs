using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split();
            double[] num = new double[items.Length];

            for (int i = 0; i <= items.Length - 1; i++)
            {
                num[i] = double.Parse(items[i]);

            }
            int[] roundedNum = new int[num.Length];

            for (int i = 0; i <= num.Length - 1; i++)
            {
                roundedNum[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", num[i], roundedNum[i]);
            }
        }
    }
}
