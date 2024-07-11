using CalcInterfaces;

namespace CalcImplementPower


{
    public class Power : AbstractCalculator, IPower
    {
        public Power(IValidation validation) : base(validation)
        {

        }

        public override double Operation(double number_one, double number_two, int decimalPlaces)
        {
            if (_validation.ValidateDivisionByZero(number_two) && 
                _validation.ValidateNonNegative(decimalPlaces)) 
            {
                double result = CustomPower(number_one, number_two);

                return Math.Round(result, decimalPlaces);
            } 
            else 
            {
                throw new Exception("");
            }
        }

        private double CustomPower(double baseNumber, double exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            double result = Math.Pow(Math.Abs(baseNumber), exponent);

            if (baseNumber < 0 && exponent % 2 != 0)
            {
                result = -result;
            }

            return result;
        }
    }
}
