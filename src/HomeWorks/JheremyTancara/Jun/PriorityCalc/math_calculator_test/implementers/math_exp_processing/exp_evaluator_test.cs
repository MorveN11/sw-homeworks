using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryEvaluatorExp;

namespace TestExpTransfWithOp


{
    [TestClass]
    public class TestExpEvaluator
    {
        [TestMethod]
        public void TestWithoutNegatives_TwoNumbers_WithOP()
        {
            var exp_1 = ExpEvaluator.Evaluate("17+2*5");
            var exp_2 = ExpEvaluator.Evaluate("17+12/2");
            var exp_3 = ExpEvaluator.Evaluate("17-6+7");

            Assert.AreEqual(27, exp_1);
            Assert.AreEqual(23, exp_2);
            Assert.AreEqual(18, exp_3);
        }
    }
}
