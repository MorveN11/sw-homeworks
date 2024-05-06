namespace HomeWorks.ManuelMorales.May.Fourth.TemplateMethod
{
    public class ReverseOrderCommaSeparatedValues : CommaSeparatedValuesTemplate
    {
        public ReverseOrderCommaSeparatedValues(string str)
            : base(str) { }

        protected override string[] Operate(string[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}
