namespace VolkovCalc.TwoArguments
{
    public class Multiply : ICalculator
    {
        /// <summary>
        /// Операция умножения
        /// </summary>
        /// <param name="first">
        /// Первый аргумент</param>
        /// <param name="second">Второй аргумент</param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        } 
    }
}