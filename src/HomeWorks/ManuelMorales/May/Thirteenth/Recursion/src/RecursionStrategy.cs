namespace Recursion
{
    public interface RecursionStrategy
    {
        int[] getInitalValues();

        int getNextValue(int[] values, int n);
    }
}
