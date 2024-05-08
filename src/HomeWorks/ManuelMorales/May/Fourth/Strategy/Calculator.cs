public class Calculator
{
    private IMathematicStrategy? _strategy;

    public Calculator() { }

    public Calculator(IMathematicStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IMathematicStrategy strategy)
    {
        _strategy = strategy;
    }

    public int Calculate(int a, int b)
    {
        if (_strategy == null)
        {
            throw new System.Exception("Strategy not defined");
        }

        return _strategy.Operate(a, b);
    }
}
