using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());

            int timeNeeded = projectsNumber * 3;


            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", nameOfArchitect, timeNeeded, projectsNumber);
        }
    }
}
