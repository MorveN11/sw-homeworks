using CalcInterfaces;

namespace CalcImplementDivision


{
    public class Division : AbstractCalculator, IDivision
    {
        public Division(IValidation validation) : base(validation)
        {

        }

        public override double Operation(double number_one, double number_two, int decimalPlaces)
        {  
            if (_validation.ValidateDivisionByZero(number_two) &&
            _validation.ValidateNonNegative(decimalPlaces))
            {
                return Math.Round(number_one / number_two, decimalPlaces);
            } 
            else 
            {
                throw new Exception("");
            }
        }
    }
}


