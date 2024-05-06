namespace HomeWorks.ManuelMorales.May.Fourth.TemplateMethod
{
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
}
