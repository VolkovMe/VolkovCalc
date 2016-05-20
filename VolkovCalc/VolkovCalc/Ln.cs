using System;

namespace VolkovCalc
{
    public class Ln : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}