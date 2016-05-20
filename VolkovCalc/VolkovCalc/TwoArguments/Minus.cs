namespace VolkovCalc.TwoArguments
{
    public class Minus : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        } 
    }
}