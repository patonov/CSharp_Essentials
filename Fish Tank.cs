using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lendth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heights = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());


            int volume = lendth * width * heights;
            double volumeLiters = volume * 0.001;
            double coefficient = percent * 0.01;

            double realVolume = volumeLiters - (volumeLiters * coefficient);


            Console.WriteLine("{0:F3}", realVolume);

        }
    }
}
