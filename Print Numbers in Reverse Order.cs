﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - i - 1] + " ");
            }
        }
    }
}
