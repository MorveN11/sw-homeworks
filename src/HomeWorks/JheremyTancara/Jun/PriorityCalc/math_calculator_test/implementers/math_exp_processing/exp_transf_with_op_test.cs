using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryTransfExp;
using Constants;

namespace TestExpTransfWithOp


{
    [TestClass]
    public class TestExpTransfWithOp
    {
        // Test With Operator Precedence
        [TestMethod]
        public void TestWithoutNegatives_TwoNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+}{17,2}", expression_one_prefix);
            Assert.AreEqual("{-}{1,52}", expression_two_prefix);
            Assert.AreEqual("{*}{93,8}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2}{+}", expression_one_suffix);
            Assert.AreEqual("{1,52}{-}", expression_two_suffix);
            Assert.AreEqual("{93,8}{*}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_TwoNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+(-2)", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("(-1)*52", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+-}{17,-2}", expression_one_prefix);
            Assert.AreEqual("{*-}{-1,52}", expression_two_prefix);
            Assert.AreEqual("{*-}{-93,8}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+(-2)", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("(-1)*52", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("(-93)*8", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,-2}{+-}", expression_one_suffix);
            Assert.AreEqual("{-1,52}{*-}", expression_two_suffix);
            Assert.AreEqual("{-93,8}{*-}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithoutNegatives_ThreeNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{*+}{2,2,17}", expression_one_prefix);
            Assert.AreEqual("{/-}{-52,2,1}", expression_two_prefix);
            Assert.AreEqual("{^*}{8,2,93}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*3", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^3", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{2,3,17}{*+}", expression_one_suffix);
            Assert.AreEqual("{-52,3,1}{/-}", expression_two_suffix);
            Assert.AreEqual("{8,3,93}{^*}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_ThreeNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+(-2)*2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-(-52)/2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^(-2)", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{*+-}{-2,2,17}", expression_one_prefix);
            Assert.AreEqual("{/-}{-52,2,1}", expression_two_prefix);
            Assert.AreEqual("{^*-}{8,-2,93}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+(-2)*2", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-(-52)/2", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^(-2)", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{-2,2,17}{*+-}", expression_one_suffix);
            Assert.AreEqual("{-52,2,1}{/-}", expression_two_suffix);
            Assert.AreEqual("{8,-2,93}{^*-}", expression_three_suffix);
        }
        
        [TestMethod]
        public void TestWithoutNegatives_FourNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2-2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/2-2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^2*3", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{*+-}{2,2,17,2}", expression_one_prefix);
            Assert.AreEqual("{/--}{52,2,1,2}", expression_two_prefix);
            Assert.AreEqual("{^**}{8,2,93,3}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*3/3", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3*4", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^3-5", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3}{+*/}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4}{-/*}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5}{*^-}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_FourNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*(-2)", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-(-52)/2-2", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8^2*3", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+**-}{17,2,2,2}", expression_one_prefix);
            Assert.AreEqual("{--/-}{1,52,2,2}", expression_two_prefix);
            Assert.AreEqual("{-*^*}{93,8,2,3}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*(-3)/3", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3*(-4)", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*(-8)^3-5", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3}{+*-/}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4}{-/*-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5}{*-^-}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithoutNegatives_FiveNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*2*3", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/2-2*5", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("93*8^2*3-4", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+***}{17,2,2,2,3}", expression_one_prefix);
            Assert.AreEqual("{-/-*}{1,52,2,2,5}", expression_two_prefix);
            Assert.AreEqual("{*^*-}{93,8,2,3,4}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+2*3/3*2", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-52/3*4-4", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*8^3-5*5", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3,2}{+*/*}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4,4}{-/*-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5,5}{*^-*}", expression_three_suffix);
        }

        [TestMethod]
        public void TestWithNegatives_FiveNumbers_WithOP()
        {
            // Prefix
            var expression_one_prefix = ExpressionTransf.Transform("17+2*2*(-2)*3", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_two_prefix = ExpressionTransf.Transform("1-52/(-2)-2*5", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);
            var expression_three_prefix = ExpressionTransf.Transform("(-93)*8^2*3-4", CalcConstants.UseOperatorPrecedence, CalcConstants.isPrefixOperator);

            Assert.AreEqual("{+**-*}{17,2,2,2,3}", expression_one_prefix);
            Assert.AreEqual("{-/--*}{1,52,2,2,5}", expression_two_prefix);
            Assert.AreEqual("{-*^*-}{93,8,2,3,4}", expression_three_prefix);

            // Suffix
            var expression_one_suffix = ExpressionTransf.Transform("17+(-2)*3/3*2", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_two_suffix  = ExpressionTransf.Transform("1-(-52)/3*4-4", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);
            var expression_three_suffix  = ExpressionTransf.Transform("93*(-8)^3-5*5", CalcConstants.UseOperatorPrecedence, CalcConstants.isSuffixOperator);

            Assert.AreEqual("{17,2,3,3,2}{+-*/*}", expression_one_suffix);
            Assert.AreEqual("{1,52,3,4,4}{--/*-}", expression_two_suffix);
            Assert.AreEqual("{93,8,3,5,5}{*-^-*}", expression_three_suffix);
        }
    }
}
