using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.VazhnikLN.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = (stopValue - startValue) + 1;
            res = new double[len];
            int k = 0;
            double f;
            for (int i = startValue; i <= stopValue; i++)
            {
                f = Math.Round((Math.Sin(i) + ((2 * i) / 3) - (4 * Math.Cos(i) * i)), 2);
                res[k] = f;
                k++;
            }
            return res;
        }
    }
}
