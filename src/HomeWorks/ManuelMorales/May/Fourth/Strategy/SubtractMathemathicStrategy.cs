namespace HomeWorks.ManuelMorales.May.Fourth.Strategy
{
    public class SubtractMathematicStrategy : IMathematicStrategy
    {
        public SubtractMathematicStrategy() { }

        public int Operate(int a, int b)
        {
            return a - b;
        }
    }
}
