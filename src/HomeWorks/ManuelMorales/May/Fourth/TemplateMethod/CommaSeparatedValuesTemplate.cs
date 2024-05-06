namespace HomeWorks.ManuelMorales.May.Fourth.TemplateMethod
{
    public abstract class CommaSeparatedValuesTemplate
    {
        private readonly string _str;

        protected CommaSeparatedValuesTemplate(String str)
        {
            this._str = OperateStr(str);
        }

        public String GetStr() => this._str;

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
}
