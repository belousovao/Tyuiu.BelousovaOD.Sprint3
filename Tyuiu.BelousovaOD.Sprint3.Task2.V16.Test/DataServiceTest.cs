using Tyuiu.BelousovaOD.Sprint3.Task2.V16.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 2;
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetMultiplySeries((int)value, startValue, stopValue);
            double wait = 14400;
            Assert.AreEqual(wait, res);
        }
    }
}