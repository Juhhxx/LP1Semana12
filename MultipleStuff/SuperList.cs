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
        public MinMaxStruct GetMinMax2()
        {
            return new MinMaxStruct(this.Min(),this.Max());
        }
        public Tuple<double,double> GetMinMax3()
        {
            return Tuple.Create(this.Min(),this.Max());
        }
        public (double Min,double Max) GetMinMax4()
        {
            return (this.Min(),this.Max());
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