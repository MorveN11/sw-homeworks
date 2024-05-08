public abstract class CommaSeparatedValuesTemplate
{
    private readonly string _csv;

    protected CommaSeparatedValuesTemplate(String str)
    {
        _csv = OperateStr(str);
    }

    public String Csv => _csv;

    private string OperateStr(String str)
    {
        string[] array = StrToArray(str);
        array = Operate(array);
        return ArrayToStr(array);
    }

    protected string[] StrToArray(string str)
    {
        return str.Split(",");
    }

    protected abstract string[] Operate(string[] array);

    protected string ArrayToStr(string[] array)
    {
        return string.Join(",", array);
    }
}
