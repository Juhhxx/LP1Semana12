using System;
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
        }
    }
}
