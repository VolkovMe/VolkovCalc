using System;

namespace VolkovCalc.TwoArguments
{
    public class Divided : ICalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception(". Деление на ноль");
            }
            return first / second;
        } 
    }
}