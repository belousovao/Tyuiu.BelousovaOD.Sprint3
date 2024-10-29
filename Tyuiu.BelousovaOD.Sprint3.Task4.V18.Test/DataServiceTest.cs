using Tyuiu.BelousovaOD.Sprint3.Task4.V18.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2.993;
            Assert.AreEqual(res, wait);
        }
    }
}