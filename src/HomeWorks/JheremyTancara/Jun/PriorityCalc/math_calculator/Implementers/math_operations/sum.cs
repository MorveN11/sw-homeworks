using CalcInterfaces;

namespace CalcImplementSum


{
    public class Sum : AbstractCalculator, ISum
    {
        public Sum(IValidation validation) : base(validation)
        {

        }

        public override double Operation(double number_one, double number_two, int decimalPlaces)
        {
            if (_validation.ValidateNonNegative(decimalPlaces)) 
            {
                return Math.Round(number_one + number_two, decimalPlaces);
            } else {
                throw new Exception("");
            }
        }
    }
}
