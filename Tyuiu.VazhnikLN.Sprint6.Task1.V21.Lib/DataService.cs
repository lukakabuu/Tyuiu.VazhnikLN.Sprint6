using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.VazhnikLN.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue  - startValue) + 1;
            double[] s = new double[len];
            double y;
            for (int i = 0; i <= len - 1; i++)
            {
                if (startValue == 1)
                {
                    s[i] = 0;
                    startValue++;
                }
                else
                {
                    y = Math.Round(Math.Cos(startValue) + (Math.Sin(startValue) / (2 - 2*startValue)) - (4 * startValue), 2);
                    s[i] = y;
                    startValue++;
                }
            }
            return s;
        }
    }
}
