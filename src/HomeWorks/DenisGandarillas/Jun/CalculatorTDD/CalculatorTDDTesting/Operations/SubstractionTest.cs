using CalculatorTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class SubstractionTest
    {
        [TestMethod]
        public void VerifyThatItIsPosiblePerformASubstraction()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 5;
            double expected = 5;

            // Execute actual operation
            var substraction = new Substraction();
            double actual = substraction.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformASubstractionWithDouble()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5;
            double expected = 5.5;

            // Execute actual operation
            var substraction = new Substraction();
            double actual = substraction.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformASubstractionWithDoubles()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5.5;
            double expected = 5;

            // Execute actual operation
            var substraction = new Substraction();
            double actual = substraction.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
