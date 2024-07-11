using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class RootTest
    {
        [TestMethod]
        public void VerifyThatItIsPosiblePerformARoot()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 5;
            double expected = 1.5848931924611136;

            // Execute actual operation
            var root = new Root();
            double actual = root.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformARootWithDouble()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5;
            double expected = 1.6004343344404715;

            // Execute actual operation
            var root = new Root();
            double actual = root.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformARootWithDoubles()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5.5;
            double expected = 1.5334541022000356;

            // Execute actual operation
            var root = new Root();
            double actual = root.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
