using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint6.Task2.V13.Lib;
namespace Tyuiu.VazhnikLN.Sprint6.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int x = 0;
            int u = 1;
            double[] res = ds.GetMassFunction(x, u);
            double[] wait = [0, -0.65];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
