using System.Text.RegularExpressions;


namespace StrategyDesignPattern
{
    class Program
    {
        static void Main()
        {
            DataValidator validator = new DataValidator(new EmailValidator());

            IsValid(validator.ValidateData("danielEspinoza@gmail.com"));
            IsValid(validator.ValidateData("danielEspinoza"));
            IsValid(validator.ValidateData("1234567890"));


            validator.SetValidator(new PhoneNumberValidator());

            IsValid(validator.ValidateData("1234567890"));
            IsValid(validator.ValidateData("daniielEspinoza@gmailcom"));
            IsValid(validator.ValidateData("12345678901212312"));
        }

        static void IsValid(bool isValidData){
            if(isValidData){
                Console.WriteLine("Data is valid");
            }else{
                Console.WriteLine("Data is not valid");
            }
        }
    }

    class DataValidator(IValidator validator)
    {
       private IValidator _validator = validator;

        public void SetValidator(IValidator validator)
        {
            _validator = validator;
        }

        public bool ValidateData(string data)
        {
            return _validator.Validate(data);
        }
    }

    interface IValidator
    {
        bool Validate(string data);
    }

    class EmailValidator : IValidator{
        public bool Validate(string data){
           string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
           return Regex.IsMatch(data, emailPattern);
        }
    }

    class PhoneNumberValidator : IValidator{

        private const int MIN_LENGTH = 7;
        private const int MAX_LENGTH = 15;

        public bool Validate(string data){
             return data.All(char.IsDigit) && data.Length >= MIN_LENGTH && data.Length <= MAX_LENGTH;
        }
    }
}