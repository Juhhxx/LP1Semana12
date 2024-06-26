﻿using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList list = new SuperList { 1, 2.5f, 3, 0.9, 5 };

            double max1 = 0;
            double min1 = list.GetMinMax1(out max1);
            Console.WriteLine($"1.\nmin:{min1} max:{max1}");

            double min2 = list.GetMinMax2().Min;
            double max2 = list.GetMinMax2().Max;
            Console.WriteLine($"2.\nmin:{min2} max:{max2}");

            double min3 = list.GetMinMax3().Item1;
            double max3 = list.GetMinMax3().Item2;
            Console.WriteLine($"3.\nmin:{min3} max:{max3}");

            double min4 = list.GetMinMax4().Min;
            double max4 = list.GetMinMax4().Max;
            Console.WriteLine($"4.\nmin:{min4} max:{max4}");
        }
    }
}
