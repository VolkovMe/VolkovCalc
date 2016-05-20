namespace VolkovCalc.OneArgument
{
    public class Sqr : ISingleCalc
    {
        public double Calculate(double first)
        {
            return first*first;
        }
    }
}