using System;

namespace VolkovCalc.OneArgument
{   
    public class Ln : ISingleCalc
    {
        /// <summary>
        /// Функция для логарифмической операции
        /// </summary>
        /// <param name="first"></param>
        /// <returns> Значение логарифмической операции</returns>
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}