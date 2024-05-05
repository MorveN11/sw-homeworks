using System.Text.RegularExpressions;

namespace HomeWorks.DenisGandarillas.May.Fourth.Strategy {

  public class NameValidationStrategy : ValidationStrategy {

    public bool validator(string name) {
      bool result = false;

      string regexName = @"^[a-zA-Z\s]+$";

      Regex regex = new Regex(regexName);

      Match match = regex.Match(name);

      if (match.Success) {
        result = true;
      }

      return result;
    }

  }

}