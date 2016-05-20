using System;

namespace VolkovCalc.OneArgument
{
    public class Sqrt : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}