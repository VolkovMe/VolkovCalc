using System;

namespace VolkovCalc.OneArgument
{
    public class Sin : ISingleCalc
    {   
        /// <summary>
        /// Функция для операции Синуса
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Значение операции</returns>
        public double Calculate(double first)
        {
            return Math.Sin(first) ;
        }
    }
}