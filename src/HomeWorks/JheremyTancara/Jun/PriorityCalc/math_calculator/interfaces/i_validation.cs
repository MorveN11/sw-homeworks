using System.Runtime.CompilerServices;

namespace CalcInterfaces


{
    public interface IValidation
    {
        bool ValidateDivisionByZero(double number);
        bool ValidateNonNegative(double number);
        bool ValidateIndexGreaterThanTwo(double index);
    }
}
