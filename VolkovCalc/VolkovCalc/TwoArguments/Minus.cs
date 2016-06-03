namespace VolkovCalc.TwoArguments
{
    public class Minus : ICalculator
    {
        /// <summary>
        /// Операция вычитания
        /// </summary>
        /// <param name="first">
        /// Первый аргумент</param>
        /// <param name="second">
        /// Второй аргумент</param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}