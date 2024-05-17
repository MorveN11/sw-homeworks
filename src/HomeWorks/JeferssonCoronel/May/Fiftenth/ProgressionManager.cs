using System.Collections;

namespace HomeWorks.JeferssonCoronel.May.Fiftenth.ProgressionManager.cs
{
    public class Progression(IPivot pivot) : IEnumerable<IPivot>
    {
        public void SetPivot(IPivot pivot1)
        {
            pivot = pivot1;
        }

        public void MakeNMovementsInProgression(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.Write(pivot.Current + ", ");
                pivot.MoveNext();
            } Console.WriteLine();
        }

        public IEnumerator<IPivot> GetEnumerator()
        {
            yield return pivot;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public interface IPivot : IEnumerator<int>
    {
        bool MoveNext();
        void Reset();
    }

    public class Fibonacci : IPivot
    {
        private int _current;
        private int _next = 1;

        public bool MoveNext()
        {
            var temp = _current;
            _current = _next;
            _next = temp + _next;
            return true;
        }

        public void Reset()
        {
            _current = 0;
            _next = 1;
        }

        public int Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }

    public class Arithmetic(int difference) : IPivot
    {
        private int _current;

        public bool MoveNext()
        {
            _current += difference;
            return true;
        }

        public void Reset()
        {
            _current = 0;
        }

        public int Current
        {
            get { return _current; }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }

    public class Geometrical(int reason) : IPivot
    {
        private int _current = 1;

        public bool MoveNext()
        {
            _current *= reason;
            return true;
        }

        public void Reset()
        {
            _current = 0;
        }

        public int Current
        {
            get { return _current; }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }

    public static class Client
    {
        static void Main()
        {
            var fibonacci = new Fibonacci();
            var arithmetic = new Arithmetic(3);
            var geometrical = new Geometrical(2);
            var progression = new Progression(fibonacci);

            Console.WriteLine("Fibonacci Sequence");
                progression.MakeNMovementsInProgression(5); //since 0 until 3
            progression.MakeNMovementsInProgression(5); //since 5 until 34

            fibonacci.Reset();
            progression.MakeNMovementsInProgression(5); //since 0 until 3

            Console.WriteLine("\n\nArithmetic Sequence");
            progression.SetPivot(arithmetic);
            progression.MakeNMovementsInProgression(5); //since 0 until 12

            Console.WriteLine("\n\nGeometrical Sequence");
            progression.SetPivot(geometrical);
            progression.MakeNMovementsInProgression(5); //since 1 until 16
        }
    }
}
