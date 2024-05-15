using System.Collections.Generic;

namespace src.HomeWorks.DenisGandarillas.May.Thirdten.Regretion
{
  public class Padovan : ISequence
  {
    public IEnumerable<long> GenerateSequence(int n)
    {
      long[] padovan = new long[n];
      padovan[0] = 1;
      padovan[1] = 1;
      padovan[2] = 1;

      for (int i = 3; i < n; i++)
      {
        padovan[i] = padovan[i - 2] + padovan[i - 3];
      }

      for (int i = 0; i < n; i++)
      {
        yield return padovan[i];
      }
    }
  }
}