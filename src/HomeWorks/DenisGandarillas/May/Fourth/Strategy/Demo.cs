namespace HomeWorks.DenisGandarillas.May.Fourth.Strategy
{

  public class Demo
  {

    public void run()
    {
      bool run = true;

      ValidationStrategy strategy;

      while (run)
      {
        Console.Clear();
        Console.WriteLine("Welcome to the VALIDATOR 3000");
        Console.WriteLine("Valitation options: \n1. Email\n2. Password\n3. Name\n4. Exit");

        string option = "";

        while (string.IsNullOrEmpty(option))
        {
          Console.WriteLine("Please enter your option: ");

          option = Console.ReadLine();
        }

        if (option == "4")
        {
          run = false;
        }
        else
        {

          if (option == "1")
          {
            strategy = new EmailValidationStrategy();

            Console.Clear();

            Console.WriteLine("Introduce your email: ");
          }
          else if (option == "2")
          {
            strategy = new PasswordValidationStrategy();

            Console.Clear();

            Console.WriteLine("Introduce your password: ");
          }
          else if (option == "3")
          {
            strategy = new NameValidationStrategy();

            Console.Clear();

            Console.WriteLine("Introduce your name: ");
          }
          else
          {
            continue;
          }

          VerifyValidation verifyValidation = new VerifyValidation();

          Console.WriteLine(verifyValidation.processValidation(strategy));

          string answer = "Y";

          Console.WriteLine("Do you want to continue [Y] or exit [N] the program?[Y is default]: ");

          answer = Console.ReadLine();

          if (answer == "n" || answer == "N")
          {
            run = false;
          }

          Console.Clear();

        }
      }

    }

  }

}