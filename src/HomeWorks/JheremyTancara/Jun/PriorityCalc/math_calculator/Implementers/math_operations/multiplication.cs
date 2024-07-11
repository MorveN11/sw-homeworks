using CalcInterfaces;

namespace CalcImplementMultiplication


{
    public class Multiplication : AbstractCalculator, IMultiplicacion
    {
        public Multiplication(IValidation validation) : base(validation)
        {

        }

        public override double Operation(double number_one, double number_two, int decimalPlaces)
        {
            if (_validation.ValidateNonNegative(decimalPlaces)) 
            {
                return Math.Round(number_one * number_two, decimalPlaces);
            } 
            else 
            {
                throw new Exception("");
            }
        }
    }
}
