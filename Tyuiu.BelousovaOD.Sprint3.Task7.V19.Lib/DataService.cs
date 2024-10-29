using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BelousovaOD.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] value;
            int len = (stopValue - startValue) + 1;
            value = new double[len];
            double y;
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) - 2 == 2)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2;
                }
                value[i] = Math.Round(y, 2);
                i++;
            }
            return value;
        }
    }
}
