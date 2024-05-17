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

    class Progression : IEnumerable<int>, IDisposable
    {
        private readonly IPivot _pivot;

        public Progression(IPivot pivot)
        {
            _pivot = pivot;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _pivot;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _pivot;
        }

        public void Dispose()
        {
            _pivot.Dispose();
        }
    }

    public class Client
    {
        public static void Main()
        {
            using (var progression = new Progression(new Fibonacci { Limit = 10 }))
            {
                foreach (var item in progression)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
