using Tyuiu.BelousovaOD.Sprint3.Task7.V19.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunctionTest()
        {
            DataService ds = new DataService();
            double[] m;
            m = new double[11];
            m[0] = 23.61;
            m[1] = 16.08;
            m[2] = 7.84;
            m[3] = 4.58;
            m[4] = 2.88;
            m[5] = 0.75;
            m[6] = -4.47;
            m[7] = -9.46;
            m[8] = -7.41;
            m[9] = -6.16;
            m[10] = -7.29;
            double[] res;
            res = new double[11];
            int start = -5, end = 5;
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(m, res);
        }
    }
}