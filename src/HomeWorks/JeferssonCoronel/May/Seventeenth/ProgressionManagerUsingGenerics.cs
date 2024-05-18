using System.Collections;

namespace HomeWorks.JeferssonCoronel.May.Seventeenth.ProgressionManagerUsingGenerics.cs
{
    public interface IProgression : IEnumerable<int>
    {
    }

    public interface IPivot : IEnumerable<int>
    {
        int Limit { set; }
    }

    public interface IGeometricProgression : IProgression
    {
        void CalculateGeometricProgression();
    }

    public interface IFibonacciProgression : IProgression
    {
        void CalculateFibonacciProgression();
    }

    public abstract class AbsProgression<T>(int limit) : IProgression
        where T : IPivot, new()
    {
        protected readonly T Pivot = new() { Limit = limit };

        public abstract IEnumerator<int> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class FibonacciProgression(int limit) : AbsProgression<Fibonacci>(limit), IFibonacciProgression
    {
        private readonly List<int> _progression = new();

        public override IEnumerator<int> GetEnumerator()
        {
            return _progression.GetEnumerator();
        }

        public void CalculateFibonacciProgression()
        {
            _progression.Clear();
            int firstNumber = 0, lastNumber = 1;
            for (var i = 0; i < Pivot.Limit; i++)
            {
                _progression.Add(firstNumber);
                var temp = firstNumber;
                firstNumber = lastNumber;
                lastNumber = temp + lastNumber;
            }
        }
    }

    public class GeometricProgression(int limit, int ratio, int firstNumber)
        : AbsProgression<Geometric>(limit), IGeometricProgression
    {
        private readonly List<int> _progression = new();

        public override IEnumerator<int> GetEnumerator()
        {
            return _progression.GetEnumerator();
        }

        public void CalculateGeometricProgression()
        {
            _progression.Clear();
            var currentTerm = firstNumber;
            for (var i = 0; i < Pivot.Limit; i++)
            {
                _progression.Add(currentTerm);
                currentTerm *= ratio;
            }
        }
    }


    public class Fibonacci : IPivot
    {
        public int Limit { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Geometric: IPivot
    {
        public int Limit { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class Client
    {
        static void Main()
        {
            Console.WriteLine("Fibonacci Progression: ");
            var fibonacciProgression = new FibonacciProgression(5);
            fibonacciProgression.CalculateFibonacciProgression();
            foreach (var number in fibonacciProgression)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine("\n\nGeometric Progression: ");
            var geometricProgression = new GeometricProgression(7, 2, 6);
            geometricProgression.CalculateGeometricProgression();
            foreach (var number in geometricProgression)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
