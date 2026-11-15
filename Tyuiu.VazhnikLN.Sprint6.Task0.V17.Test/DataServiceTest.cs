using Tyuiu.VazhnikLN.Sprint6.Task0.V17.Lib;
namespace Tyuiu.VazhnikLN.Sprint6.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.Calculate(x);
            double wait = Math.E;
            Assert.AreEqual(wait, res);
        }
    }
}
