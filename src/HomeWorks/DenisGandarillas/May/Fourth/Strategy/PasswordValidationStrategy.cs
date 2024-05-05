using System.Text.RegularExpressions;

namespace HomeWorks.DenisGandarillas.May.Fourth.Strategy {

    public class PasswordValidationStrategy : ValidationStrategy
    {
        public bool validator(string password)
        {
            bool result = false;

            string passwordRegex = "^[a-zA-Z0-9]+$";

            Regex regex = new Regex(passwordRegex);

            Match match = regex.Match(password);

            if (match.Success) {
              result = true;
            }

            return result;
        }
    }

}