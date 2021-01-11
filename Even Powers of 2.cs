using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int power = 0; power <= num; power++)
            {
                if (power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }
            }
        }
    }
}
