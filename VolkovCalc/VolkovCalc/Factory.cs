using System;

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
                case "multiply":
                    return new Multiply();
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}