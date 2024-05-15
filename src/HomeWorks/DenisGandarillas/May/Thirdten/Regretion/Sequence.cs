namespace src.HomeWorks.DenisGandarillas.May.Thirdten.Regretion
{

  public class Sequence
  {

    private readonly ISequence _algorithm;

    public Sequence(ISequence algorithm)
    {
      _algorithm = algorithm;
    }

    public IEnumerable<long> GenerateSequence(int n)
    {
      return _algorithm.GenerateSequence(n);
    }

  }

}