using CalcInterfaces;

namespace CalcValidation


{
    public class ValidationTwo : IValidation
    {
        public bool ValidateDivisionByZero(double number)
        {
            return (number == 0);
        }

        public bool ValidateNonNegative(double number)
        {
            return (number < 0);
        }

        public bool ValidateIndexGreaterThanTwo(double index)
        {
            return (index < 2);
        }
    }
}
