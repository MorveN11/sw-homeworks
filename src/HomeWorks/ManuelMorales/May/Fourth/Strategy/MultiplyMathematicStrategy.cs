namespace HomeWorks.ManuelMorales.May.Fourth.Strategy
{
    public class MultiplyMathematicStrategy : IMathematicStrategy
    {
        public MultiplyMathematicStrategy() { }

        public int Operate(int a, int b)
        {
            return a * b;
        }
    }
}
