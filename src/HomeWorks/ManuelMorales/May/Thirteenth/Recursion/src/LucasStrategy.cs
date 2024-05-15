namespace Recursion
{
    public class LucasStrategy : RecursionStrategy
    {
        public int[] getInitalValues()
        {
            return new int[] { 2, 1 };
        }

        public int getNextValue(int[] values, int n)
        {
            return values[n - 1] + values[n - 2];
        }
    }
}
