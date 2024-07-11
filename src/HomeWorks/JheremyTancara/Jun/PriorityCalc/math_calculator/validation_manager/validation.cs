using CalcInterfaces;

namespace CalcValidation


{
    [Obsolete]
    public static class Validation
    {
        public static void ValidateDivisionByZero(double number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public static void ValidateNonNegative(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Decimal places cannot be negative.");
            }
        }

        public static void ValidateIndexGreaterThanTwo(double index)
        {
            if (index < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "The index must be greater than or equal than 2.");
            }
        }
    }
}
