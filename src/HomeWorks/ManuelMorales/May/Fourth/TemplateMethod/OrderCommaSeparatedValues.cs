public class OrderCommaSeparatedValues : CommaSeparatedValuesTemplate
{
    public OrderCommaSeparatedValues(string str)
        : base(str) { }

    protected override string[] Operate(string[] array)
    {
        Array.Sort(array);
        return array;
    }
}
