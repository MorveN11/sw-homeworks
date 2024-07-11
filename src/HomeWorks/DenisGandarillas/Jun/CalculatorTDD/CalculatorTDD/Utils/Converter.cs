using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorTDD
{
    public class Converter
    {
        public string convertListToString(MatchCollection matches)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matches.Count; i++)
            {
                result.Append(matches[i].Value);
                if (i < matches.Count - 1)
                {
                    result.Append(",");
                }
            }

            return result.ToString();
        }
    }
}
