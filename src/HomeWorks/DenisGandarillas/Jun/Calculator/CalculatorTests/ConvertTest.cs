namespace CalculatorTests
{

    [TestClass]
    public class ConvertTest()
    {

        [TestMethod]
        public void VerifyThanSingleOperationConversion()
        {
            string add = "2+3";
            string expected = "+|2,3";

            var conversion = new OperationConverter();
        }

    }

}
