using System.Data;
using System.Text.RegularExpressions;

namespace LibraryEvaluatorExp


{
    public static class ExpEvaluator
    {
        public static double Evaluate(string expression)
        {
            expression = Regex.Replace(expression, @"\s+", "");

            DataTable table = new DataTable();
            var result = table.Compute(expression, "");

            return Convert.ToDouble(result);
        }
    }
}
