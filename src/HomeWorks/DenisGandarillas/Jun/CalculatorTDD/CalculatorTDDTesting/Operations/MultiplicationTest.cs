using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void VerifyThatItIsPosiblePerformAMultiplication()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 5;
            double expected = 50;

            // Execute actual operation
            var multiplication = new Multiplication();
            double actual = multiplication.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformAMultiplicationWithDouble()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5;
            double expected = 52.5;

            // Execute actual operation
            var multiplication = new Multiplication();
            double actual = multiplication.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformAMultiplicationWithDoubles()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5.5;
            double expected = 57.75;

            // Execute actual operation
            var multiplication = new Multiplication();
            double actual = multiplication.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
