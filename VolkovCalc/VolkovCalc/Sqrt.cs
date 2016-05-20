using System;

namespace VolkovCalc
{
    public class Sqrt : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}