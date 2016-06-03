namespace VolkovCalc.OneArgument
{
    public class Sqr : ISingleCalc
    {
        /// <summary>
        /// Операция возведения в квадрат
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Значение операции</returns>
        public double Calculate(double first)
        {
            return first*first;
        }
    }
}