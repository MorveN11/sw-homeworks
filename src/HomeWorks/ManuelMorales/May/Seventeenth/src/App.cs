using System.Collections;

namespace Fifteenth.Progression
{
    interface IPivot : IEnumerator<int>
    {
        int Limit { get; set; }
    }

    class Fibonacci : IPivot
    {
        public int Limit { get; set; }

        public int Current { get; set; }

        object IEnumerator.Current => Current;

        private int _count = 0;

        private List<int>? _sequence = new List<int> { 0, 1, 1 };

        public bool MoveNext()
        {
            if (Limit == 0)
            {
                return false;
            }

            Limit--;

            if (_count < 3)
            {
                Current = _sequence?[_count++] ?? 0;
                return true;
            }

            _sequence?.Add((_sequence?[_count - 1] ?? 0) + (_sequence?[_count - 2] ?? 0));

            Current = _sequence?[_count++] ?? 0;

            return true;
        }

        public void Dispose()
        {
            _count = 0;
            _sequence?.Clear();
            _sequence = null;
        }

        public void Reset()
        {
            Current = 0;
        }
    }

    class Factorial : IPivot
    {
        public int Limit { get; set; }

        public int Current { get; private set; } = 1;

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (Limit == 1)
            {
                return false;
            }

            Current *= Limit;
            Limit--;

            return true;
        }

        public void Dispose()
        {
            Current = 0;
            Limit = 0;
        }

        public void Reset()
        {
            Current = 1;
        }
    }

    interface IProgression : IEnumerable<int>, IDisposable { }

    abstract class AbstractProgression : IProgression
    {
        protected IPivot Pivot;

        protected AbstractProgression(IPivot pivot)
        {
            Pivot = pivot;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return Pivot;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Pivot;
        }

        public void Dispose()
        {
            Pivot.Dispose();
        }
    }

    class FibonacciProgression : AbstractProgression
    {
        public FibonacciProgression(int limit)
            : base(new Fibonacci { Limit = limit }) { }
    }

    class FactorialProgression : AbstractProgression
    {
        public FactorialProgression(int limit)
            : base(new Factorial { Limit = limit }) { }
    }

    public class Client
    {
        public static void Main()
        {
            Console.WriteLine("Fibonacci Progression:");
            using (var progression = new FibonacciProgression(10))
            {
                foreach (var item in progression)
                {
                    Console.Write($"{item} ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Factorial Progression:");
            using (var factorial = new FactorialProgression(5))
            {
                foreach (var item in factorial)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
