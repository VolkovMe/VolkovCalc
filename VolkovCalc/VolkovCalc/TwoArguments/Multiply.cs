namespace VolkovCalc.TwoArguments
{
    public class Multiply : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        } 
    }
}