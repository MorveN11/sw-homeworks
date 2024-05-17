namespace Recursion
{
    public class FibonacciStrategy : RecursionStrategy
    {
        public int[] getInitalValues()
        {
            return new int[] { 0, 1 };
        }

        public int getNextValue(int[] values, int n)
        {
            return values[n - 1] + values[n - 2];
        }
    }
}
