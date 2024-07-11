using CalcInterfaces;

public abstract class AbstractCalculator : ICalculator
{
    protected readonly IValidation _validation;
    protected AbstractCalculator(IValidation validation)
    {
        _validation = validation;
    }

    public abstract double Operation(double number_one, double number_two, int decimalPlaces);
}
