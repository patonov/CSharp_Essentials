using System;

namespace SquarePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			if (n > 0 && n <= 30)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						Console.Write("# ");
					}
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("Try again later!");
			}

		}
	}
}
