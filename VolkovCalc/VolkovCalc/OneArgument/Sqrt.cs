using System;

namespace VolkovCalc.OneArgument
{
    /// <summary>
    /// Операция извлечения корня
    /// </summary>
    public class Sqrt : ISingleCalc
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}