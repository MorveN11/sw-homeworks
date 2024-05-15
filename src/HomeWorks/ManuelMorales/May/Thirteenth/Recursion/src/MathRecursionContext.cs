namespace Recursion
{
    public class MathRecursionContext
    {
        private RecursionStrategy? _strategy;

        private int[]? _sequence;

        public MathRecursionContext() { }

        public void setStrategy(RecursionStrategy strategy) => _strategy = strategy;

        public int[] getSequence(int n)
        {
            if (_strategy == null)
                throw new System.Exception("No strategy has been set.");

            int[] sequence = new int[n];
            int[] values = _strategy.getInitalValues();

            for (int i = 0; i < values.Length; i++)
            {
                sequence[i] = values[i];
            }

            for (int i = values.Length; i < n; i++)
            {
                sequence[i] = _strategy.getNextValue(sequence, i);
            }

            return _sequence = sequence;
        }
    }
}
