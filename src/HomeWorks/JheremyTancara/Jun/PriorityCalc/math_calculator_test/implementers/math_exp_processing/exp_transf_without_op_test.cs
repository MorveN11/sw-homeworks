using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryTransfExp;
using Constants;

namespace TestExpTransfWithoutOp


{
    [TestClass]
    public class TestExpTransfWithoutOp
    {
        // Test Without Operator Precedence
        [TestMethod]
        public void TestWithoutNegatives_TwoNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+}{17,2}", expression_one_prefix);
            Assert.AreEqual("{-}{1,52}", expression_two_prefix);
            Assert.AreEqual("{*}{93,8}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2}{+}", expression_one_suffix);
            Assert.AreEqual("{1,52}{-}", expression_two_suffix);
            Assert.AreEqual("{93,8}{*}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_TwoNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+(-2)", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("(-1)*52", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+-}{17,2}", expression_one_prefix);
            Assert.AreEqual("{-*}{1,52}", expression_two_prefix);
            Assert.AreEqual("{-*}{93,8}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+(-2)", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("(-1)*52", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("(-93)*8", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2}{+-}", expression_one_suffix);
            Assert.AreEqual("{1,52}{-*}", expression_two_suffix);
            Assert.AreEqual("{93,8}{-*}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithoutNegatives_ThreeNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+*}{17,2,2}", expression_one_prefix);
            Assert.AreEqual("{-/}{1,52,2}", expression_two_prefix);
            Assert.AreEqual("{*^}{93,8,2}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3}{+*}", expression_one_suffix);
            Assert.AreEqual("{1,52,3}{-/}", expression_two_suffix);
            Assert.AreEqual("{93,8,3}{*^}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_ThreeNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*(-2)", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("(-1)-52/2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8^2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+*-}{17,2,2}", expression_one_prefix);
            Assert.AreEqual("{--/}{1,52,2}", expression_two_prefix);
            Assert.AreEqual("{-*^}{93,8,2}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+(-2)*3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/(-3)", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("(-93)*8^3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3}{+-*}", expression_one_suffix);
            Assert.AreEqual("{1,52,3}{-/-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3}{-*^}", expression_three_suffix);
        }
        
        [TestMethod]
        public void TestWithoutNegatives_FourNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/2-2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^2*3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+**}{17,2,2,2}", expression_one_prefix);
            Assert.AreEqual("{-/-}{1,52,2,2}", expression_two_prefix);
            Assert.AreEqual("{*^*}{93,8,2,3}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*3/3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3*4", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^3-5", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3}{+*/}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4}{-/*}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5}{*^-}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_FourNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*(-2)", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-(-52)/2-2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8^2*3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+**-}{17,2,2,2}", expression_one_prefix);
            Assert.AreEqual("{--/-}{1,52,2,2}", expression_two_prefix);
            Assert.AreEqual("{-*^*}{93,8,2,3}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*(-3)/3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3*(-4)", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*(-8)^3-5", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3}{+*-/}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4}{-/*-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5}{*-^-}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithoutNegatives_FiveNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*2*3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/2-2*5", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^2*3-4", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+***}{17,2,2,2,3}", expression_one_prefix);
            Assert.AreEqual("{-/-*}{1,52,2,2,5}", expression_two_prefix);
            Assert.AreEqual("{*^*-}{93,8,2,3,4}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*3/3*2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3*4-4", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^3-5*5", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3,2}{+*/*}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4,4}{-/*-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5,5}{*^-*}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_FiveNumbers_WithoutOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*(-2)*3", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/(-2)-2*5", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8^2*3-4", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+**-*}{17,2,2,2,3}", expression_one_prefix);
            Assert.AreEqual("{-/--*}{1,52,2,2,5}", expression_two_prefix);
            Assert.AreEqual("{-*^*-}{93,8,2,3,4}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+(-2)*3/3*2", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-(-52)/3*4-4", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*(-8)^3-5*5", CalcConstants.NotUseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3,2}{+-*/*}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4,4}{--/*-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5,5}{*-^-*}", expression_three_suffix);
        }
    }
}
