
namespace VolkovCalc.OneArgument
{
    /// <summary>
    /// Общий интерфейс для классов с одним аргументом
    /// </summary>
    public interface ISingleCalc
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first">
        /// Первый аргумент
        /// </param>
        /// <returns></returns>
        double Calculate(double first);
    }
}