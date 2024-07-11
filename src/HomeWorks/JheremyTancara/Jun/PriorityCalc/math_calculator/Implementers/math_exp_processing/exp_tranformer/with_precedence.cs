namespace MathLibraryTransfWith


{
    public static class WithPrecedenceExpTransf
    {        
        public static (string,string) Evaluate(string input)
        {
            char[] operatorsPrecedence = new char[]{'^', '\'', '*', '/', '+', '-'};
            string listNumber = "";
            string listOperator = "";
            bool isNegative = false;
            int account = 0;
            int counter = 0;

            List<string> numbers = new List<string>();;
            List<string> operators = new List<string>();
            List<bool> isNumber = new List<bool>();

            for (int i = 0; i < input.Length; i++)
            {
                isNumber.Add(false);
            }

            for (int i = 0; i < operatorsPrecedence.Length; i++)
            {
                int index = input.IndexOf(operatorsPrecedence[i]);
                if (index != -1)
                {
                    // Operator
                    if (!isNumber[index]) {
                        string operatorFound = input.Substring(index, 1);
                        operators.Add(operatorFound);
                        isNumber[index] = true;
                    }

                    // Numbers
                    if (index-1 >= 0) {
                        //Left
                        for (int j = 1; j <= index; j++)
                        {
                            if (input[index-j] == '-') {
                                isNegative = true;
                                account = index-j;
                                break;
                            } else if (input[index-j] == '^' || input[index-j] == '\'' || input[index-j] == '*' || input[index-j] == '/' || input[index-j] == '+') {
                                account = index-j;
                                break;
                            } else {
                                account = index-j-1;
                            }
                        }
                        if (isNegative) {
                            if (!isNumber[index-1]) {
                                numbers.Add("-" + input.Substring(account+1, index-account-1));
                                isNegative = false;
                                for (int k = 1; k <= index-account-1; k++) {
                                    isNumber[account + k] = true;
                                }
                            }
                        } else  {
                            if (!isNumber[index-1]) {
                                numbers.Add(input.Substring(account+1, index-account-1));
                                for (int k = 1; k <= index-account-1; k++) {
                                    isNumber[account + k] = true;
                                }                        
                            }
                        }

                        //Right
                        if (input[index+1] == '-') {
                            isNegative = true;
                            counter = 1;
                        } 
                        for (int l=1; l+counter+index < input.Length; l++) {
                            if (input[index+counter+l]== '^' || input[index+counter+l] == '\'' || input[index+counter+l] == '*' || input[index+counter+l] == '/' || input[index+counter+l] == '+' || input[index+counter+l] == '-') {
                                account = index+l+counter-1;
                                break;
                            } else {
                                account = input.Length-1;
                            }
                        }
                        
                        if (isNegative) {
                            if (!isNumber[index+2]) {
                                numbers.Add("-" + input.Substring(index+2, account-index-1));
                                isNegative = false;
                                for (int k = 1; k <= account-index-1; k++) {
                                    isNumber[index+1+k] = true;
                                }
                            }
                        } else {
                            if (!isNumber[index+1]) {
                                numbers.Add(input.Substring(index+1, account-index));
                                for (int k = 1; k <= account-index; k++) {
                                    isNumber[index+k] = true;
                                }                        
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++) {
                if (i == numbers.Count - 1) {
                    listNumber += numbers[i];
                } else {
                    listNumber += numbers[i] + ",";
                }
            }

            foreach (string op in operators)
            {
                listOperator += op;
            }

            return (listOperator, listNumber);
        }
    }
}
