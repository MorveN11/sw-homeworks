using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public class Converter
    {

        public Tuple<List<char>, List<int>> OperationConverter(string operation)
        {
            List<char> operators = new List<char>();
            List<int> numbers = new List<int>();

            string numberAuxiliar = "";

            foreach (char item in operation)
            {
                if (Char.IsDigit(item))
                {
                    numberAuxiliar += item;
                }
                else
                {
                    if (numberAuxiliar!= "")
                    {
                        numbers.Add(Convert.ToInt32(numberAuxiliar));
                        numberAuxiliar = "";
                    }
                    operators.Add(item);
                }
            }

            if (!string.IsNullOrEmpty(numberAuxiliar))
            {
                numbers.Add(Convert.ToInt32(numberAuxiliar));
            }

            return new Tuple<List<char>, List<int>>(operators, numbers);
        }

        public string ToString(Tuple<List<char>, List<int>> tuple)
        {
            StringBuilder result = new StringBuilder();

            result.Append(convertListToString(tuple.Item1));

            result.Append("|");

            result.Append(convertListToString(tuple.Item2));

            return result.ToString();
        }

        private string convertListToString<T>(List<T> list)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                result.Append(list[i]);
                if (i <= list.Count - 2)
                {
                    result.Append(",");
                }
            }

            return result.ToString();
        }
    }
}
