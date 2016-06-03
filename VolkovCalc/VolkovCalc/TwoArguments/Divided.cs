using System;

namespace VolkovCalc.TwoArguments
{
    public class Divided : ICalculator
    {
        /// <summary>
        /// Операция деления
        /// </summary>
        /// <param name="first">
        /// Первый аргумент</param>
        /// <param name="second">
        /// Второй аргумент</param>
        /// <returns></returns>
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