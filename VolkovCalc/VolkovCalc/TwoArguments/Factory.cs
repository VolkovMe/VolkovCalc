using System;

namespace VolkovCalc.TwoArguments
{
    public static class Factory
    {
        /// <summary>
        /// Фабрика для операций с двумя аргументами
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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