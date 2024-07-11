using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryEvaluatorExp;
using LibraryTransfExp;
using Constants;

namespace TestOperatorsTransf


{
    [TestClass]
    public class TestExpEvaluator
    {
        [TestMethod]
        public void TestWithoutNegatives_TwoNumbers_WithOP()
        {
            var exp_1 = OperatorTransf.Transform("+-*", CalcConstants.UseOperatorPrecedence);

            Assert.AreEqual("{*+-}", exp_1);
        }
    }
}
