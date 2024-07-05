using CalculatorTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class ConverterTest
    {

        [TestMethod]
        public void VerifyThatGetOnlyDigits()
        {
            string operation = "2+3*4-5/6";
            string expected = "2,3,4,5,6";

            var converter = new Converter();

            string actual = converter.GetDigits(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatGetOnlyOperators()
        {
            string operation = "2+3*4-5/6";
            string expected = "+,*,-,/";

            var converter = new Converter();

            string actual = converter.GetOperators(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesAdditionInASimpleExercise()
        {
            string operation = "2+3";
            string expected = "+|2,3";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesSubstractionInASimpleExercise()
        {
            string operation = "43-1";
            string expected = "-|43,1";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesMultiplicationInASimpleExercise()
        {
            string operation = "42*12";
            string expected = "*|42,12";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesDivisionInASimpleExercise()
        {
            string operation = "24/4";
            string expected = "/|24,4";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesAdditionInAExerciseWithThreeNumbers()
        {
            string operation = "1+2+3";
            string expected = "+,+|1,2,3";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesSubstractionInAExerciseWithThreeNumbers()
        {
            string operation = "4-2-1";
            string expected = "-,-|4,2,1";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesMultiplicationInAExerciseWithThreeNumbers()
        {
            string operation = "2*3*4";
            string expected = "*,*|2,3,4";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesDivisionInAExerciseWithThreeNumbers()
        {
            string operation = "12/4/6";
            string expected = "/,/|12,4,6";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesComplexExercisesOne()
        {
            string operation = "2+3*4-5/6";
            string expected = "+,*,-,/|2,3,4,5,6";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheConverterHandlesComplexExercisesTwo()
        {
            string operation = "100/20+31-42/5";
            string expected = "/,+,-,/|100,20,31,42,5";

            var converter = new Converter();

            string actual = converter.OperationConverter(operation);

            Assert.AreEqual(expected, actual);
        }

        // [TestMethod]
        // public void VerifyThanTheConverterHandlesComplexExercisesWithParentheses()
        // {
        //     string operation = "(2+3)*4-5/(6+7)";
        //     string expected = "(,+,),*,-,/,(,+,)|2,3,4,5,6,7";

        //     var converter = new Converter();

        //     string actual = converter.OperationConverter(operation);

        //     Assert.AreEqual(expected, actual);
        // }

    }
}
