namespace src.HomeWorks.DenisGandarillas.May.Thirdten.Regretion
{

  public class Fibonazi : ISequence
  {

    public IEnumerable<long> GenerateSequence(int n)
    {

      long n1 = 0, n2 = 1;

      for (int i = 0; i < n; i++)
      {

        long aux = n1;

        n1 = n2;

        n2 = aux + n1;

        yield return n1;

      }

    }

  }

}