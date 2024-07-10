using Calculator.Utils;

namespace Calculator.Operations.Concretes;

public class Root : AbstractOperation
{
    private double _index;
    private double _radicand;

    public Root(double index, double redicand)
    {
        _index = index;
        _radicand = redicand;
    }

    public Root()
    {
    }

    public override double ExecuteOperation()
    {
        if (_radicand < 0) throw new ArgumentException("Cannot take square root of a negative number");
        var result = Math.Pow(_radicand, 1 / _index);
        return result;
    }
    
    public override void SetParameters(double index, double redicand)
    {
        _index = index;
        _radicand = redicand;
    }
}