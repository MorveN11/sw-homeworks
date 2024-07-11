using MathLibraryTransfWith;
using MathLibraryTransfWithout;

namespace LibraryTransfExp


{
    public class OperatorTransf
    {        
        public static string Transform(string input, bool operatorPrecedence)
        {
            if (operatorPrecedence)
            {
                string operators = WithPrecedenceExpTransf.Evaluate(input).Item1;
                return "{" + operators + "}";
            }
            else
            {
                string operators = WithoutPrecedenceExpTransf.Evaluate(input).Item1;
                return "{" + operators + "}";
            }
        }
    }
}
