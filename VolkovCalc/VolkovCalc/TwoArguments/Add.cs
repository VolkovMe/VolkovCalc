﻿namespace VolkovCalc.TwoArguments
{
    public class Add: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}