using System;

namespace VolkovCalc
{
    public class Sin : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Sin(first) ;
        }
    }
}