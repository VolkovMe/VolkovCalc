using System;
using System.Diagnostics;

namespace VolkovCalc
{
    public class Factory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "plus":
                    return new Add();
                case "minus":
                    return new Minus();
                case "divided":
                    return new Divided();
                case "Multiply":
                    return new Multiply();
                default:
                    throw new Exception("Неизвестная операция");
            }
            
        }

    }
}