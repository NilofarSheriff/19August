﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise11
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the start and end value to do the actions");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for(int i = start; i <= end; i++)
            {
                
                    Console.WriteLine(i);
                    sum = sum + i;
                
               
                
            }
            Console.WriteLine("The sum of the integers between {0} and {1} is {2}",start, end, sum);

            Console.ReadLine();
        }
    }
}
