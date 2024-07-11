using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void VerifyThatItIsPosiblePerformADivision()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 5;
            double expected = 2;

            // Execute actual operation
            var division = new Division();
            double actual = division.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformADivisionWithDouble()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5;
            double expected = 2.1;

            // Execute actual operation
            var division = new Division();
            double actual = division.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformADivisionWithDoubles()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5.5;
            double expected = 1.9090909090909090909090909090909;

            // Execute actual operation
            var division = new Division();
            double actual = division.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Cannot division by zero :c")]
        public void VerifyThatItIsPosiblePerformADivisionWithZero()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 0;

            // Execute actual operation
            var division = new Division();
            division.Execute(number1, number2);
        }
    }
}
