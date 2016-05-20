using System;

namespace VolkovCalc.OneArgument
{
    public class Sin : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Sin(first) ;
        }
    }
}