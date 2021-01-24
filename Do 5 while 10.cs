using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_5_while_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

                if (i > 5)
                {
                    break;
                }

            } while (i < 10);
        }
    }
}
