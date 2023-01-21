namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaRectangle()
        {
            int result = CalcularArea.Calculator.RectangleCalculator(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AreaCircle()
        {
            var result = CalcularArea.Calculator.CircleCalculator(Convert.ToDouble(2));
            Assert.AreEqual("12,566370614359172", result.ToString());
        }
    }
}