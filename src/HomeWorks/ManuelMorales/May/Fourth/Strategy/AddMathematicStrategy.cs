namespace HomeWorks.ManuelMorales.May.Fourth.Strategy
{
    public class AddMathematicStrategy : IMathematicStrategy
    {
        public AddMathematicStrategy() { }

        public int Operate(int a, int b)
        {
            return a + b;
        }
    }
}
