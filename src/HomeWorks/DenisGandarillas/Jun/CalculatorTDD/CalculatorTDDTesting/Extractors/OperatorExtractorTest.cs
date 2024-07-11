using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class OperatorExtractorTest
    {
        [TestMethod]
        public void VerifyThatExtractOperatorInSimpleOperation()
        {
            // Inputs and outputs
            string operation = "1+2";
            string expected = "+";

            // Execute actual operation
            var extractor = new OperatorExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatExtractOperatorsInComplexOperation()
        {
            // Inputs and outputs
            string operation = "24*12/1";
            string expected = "*,/";

            // Execute actual operation
            var extractor = new OperatorExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatExtractOperatorsInOperationWithParentheses()
        {
            // Inputs and outputs
            string operation = "(2+3)*4";
            string expected = "(,+,),*";

            // Execute actual operation
            var extractor = new OperatorExtractor();
            string actual = extractor.Extract(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
