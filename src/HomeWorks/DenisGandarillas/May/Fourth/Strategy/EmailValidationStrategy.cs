using System.Text.RegularExpressions;

namespace HomeWorks.DenisGandarillas.May.Fourth.Strategy {

    public class EmailValidationStrategy : ValidationStrategy
    {
        public bool validator(String email)
        {
            bool result = false;
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(emailRegex);

            Match match = regex.Match(email);

            if (match.Success)
            {
                result = true;
            }

            return result;
        }
    }

}