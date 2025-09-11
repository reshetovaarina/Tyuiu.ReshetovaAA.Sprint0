using Tyuiu.ReshetovaAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ReshetovaAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Арина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Арина", res);
        }
    }
}
