using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void VerifyThatParserCanParseSimpleOperation()
        {
            // Inputs and outputs
            string operation = "1+2";
            string expected = "+|1,2";

            // Execute actual operation
            var parser = new Parser();
            string actual = parser.Parse(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatParserCanParseComplexOperation()
        {
            // Inputs and outputs
            string operation = "123+22*3/4";
            string expected = "+,*,/|123,22,3,4";

            // Execute actual operation
            var parser = new Parser();
            string actual = parser.Parse(operation);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
