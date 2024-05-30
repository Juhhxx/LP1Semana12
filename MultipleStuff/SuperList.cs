using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public double GetMinMax1(out double max)
        {
            max = this.Max();
            return this.Min();
        }
        
        public struct MinMaxStruct
        {
            public double Min { get; }
            public double Max { get; }

            public MinMaxStruct(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }
    }
}