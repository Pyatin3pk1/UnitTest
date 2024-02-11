using MyLib;
namespace TestProjectMyLib

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void AddTest()
        {
            double x = 10;
            double y = 20;
            double expected = 30;//всё верно


            double actual = MathOperations.Add(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double x = 20;
            double y = 10;
            double expected = 9;//допущена ошибка

            double actual = MathOperations.Subtract(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double x = 7;
            double y = 7;
            double expected = 48;//допущена ошибка

            double actual = MathOperations.Multiply(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            double x = 14;
            double y = 7;
            double expected = 2;//всё верно

            double actual = MathOperations.Divide(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PowTest()
        {
            double x = 11;
            double y = 2;
            double expected = 121;//всё верно

            double actual = MathOperations.Pow(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}