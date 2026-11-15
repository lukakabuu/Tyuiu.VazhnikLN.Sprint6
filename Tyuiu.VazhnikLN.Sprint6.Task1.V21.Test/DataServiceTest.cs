using Tyuiu.VazhnikLN.Sprint6.Task1.V21.Lib;
namespace Tyuiu.VazhnikLN.Sprint6.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunctionValid()
        {
            DataService ds = new DataService();
            int s = 0;
            int k = 1;
            double[] res = ds.GetMassFunction(s, k);
            double[] wait = [1, 0];
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
