using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class PowTest
    {
        [TestMethod]
        public void VerifyThatItIsPosiblePerformAPow()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 5;
            double expected = 100000;

            // Execute actual operation
            var pow = new Pow();
            double actual = pow.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformAPowWithDouble()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5;
            double expected = 127628.15625;

            // Execute actual operation
            var pow = new Pow();
            double actual = pow.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformAPowWithDoubles()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5.5;
            double expected = 413562.49323606625;

            // Execute actual operation
            var pow = new Pow();
            double actual = pow.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
