using System;

namespace VolkovCalc.OneArgument
{
    public class Ln : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}