using CalcInterfaces;

namespace CalcImplementRoot


{
    public class Root : AbstractCalculator, IRoot
    {
        public Root(IValidation validation) : base(validation)
        {

        }

        public override double Operation(double number_one, double number_two, int decimalPlaces)
        {
            if (_validation.ValidateNonNegative(number_one) &&
                _validation.ValidateNonNegative(decimalPlaces) &&
                _validation.ValidateIndexGreaterThanTwo(number_two)) 
            {
                return Math.Round(Math.Pow(number_one, 1.0 / number_two), decimalPlaces);
            } else {
                throw new Exception("");
            };
        }
    }
}
