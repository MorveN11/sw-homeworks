using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class DigitsExtractorTest
    {
        [TestMethod]
        public void VerifyThatExtractSimpleDigitInSimpleOperation()
        {
            // Inputs and outputs
            string operation = "1+2";
            string expected = "1,2";

            // Execute actual operation
            var extractor = new DigitsExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatExtractSimpleDigitInComplexOperation()
        {
            // Inputs and outputs
            string operation = "1+2*3/4-5";
            string expected = "1,2,3,4,5";

            // Execute actual operation
            var extractor = new DigitsExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatExtractComplexDigitsInSimpleOperation()
        {
            // Inputs and outputs
            string operation = "123+22";
            string expected = "123,22";

            // Execute actual operation
            var extractor = new DigitsExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatExtractComplexDigitsInComplexOperation()
        {
            // Inputs and outputs
            string operation = "10+72*873/34-25";
            string expected = "10,72,873,34,25";

            // Execute actual operation
            var extractor = new DigitsExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
