using System;

namespace VolkovCalc.OneArgument
{
    public static class SingleFactory
    {   
        /// <summary>
        /// Фабрика для операций с одним аргументом
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ISingleCalc CreateCalculator(string name)
        {   
            switch (name)
            {
                case "button1":
                    return new Sin();
                case "button2":
                    return new Ln();
                case "button4":
                    return new Sqr();
                case "button3":
                    return new Sqrt();
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}