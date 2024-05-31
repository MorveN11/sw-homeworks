using System.Collections;

    public interface IPivot : IEnumerator<int>
    {
        int Current { get; }
    }

    public interface IProgression : IEnumerable<int>
    {

    }

    public interface ProgressionFactory
    {
        IPivot CreatePivot(int limit);
        IProgression CreateProgression(int limit);
    }

    public class FibonacciFactory : ProgressionFactory
    {
        public IPivot CreatePivot(int limit)
        {
            return new FibonacciPivot(limit);
        }

        public IProgression CreateProgression(int limit)
        {
            return new FiboProgression(limit);
        }
    }

    public class ArithmeticFactory : ProgressionFactory
    {
        public IPivot CreatePivot(int limit)
        {
            return new ArithmeticPivot(){_start = 0, _step = 1, _limit = limit};
        }

        public IProgression CreateProgression(int limit)
        {
            return new ArithmeticProgression(0, 1, limit);
        }
    }

    public class FiboProgression : IProgression
    {
        private int _limit;

        public FiboProgression(int limit){
            _limit = limit;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new FibonacciPivot(_limit);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class FibonacciPivot : IPivot
    {
        private int _a = 0;
        private int _b = 1;
        private int _currIteration = 0;
        private int _limit;

        public FibonacciPivot(int limit)
        {
            _limit = limit;
        }

        public int Current => _a;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (_currIteration == 0)
            {
                _currIteration++;
                return _a < _limit;
            }

            int tmp = _a + _b;
            _a = _b;
            _b = tmp;

            _currIteration++;

            return _a < _limit;
        }

        public void Reset()
        {
            _a = 0;
            _b = 1;
            _currIteration = 0;
        }
    }

    public class ArithmeticProgression : IProgression
    {
        private int _start;
        private int _step;
        private int _limit;

        public ArithmeticProgression(int start, int step, int limit)
        {
            _start = start;
            _step = step;
            _limit = limit;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new ArithmeticPivot(){_start = _start, _step = _step, _limit = _limit};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class ArithmeticPivot : IPivot
    {
        public int _start{get; set;}
        public int _step{get; set;}
        public int _limit{get; set;}
        private int _currIteration = 0;
        public int Current => _start + _step * _currIteration;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (_currIteration == 0)
            {
                _currIteration++;
                return _start < _limit;
            }

            _start += _step;
            _currIteration++;
            return _start < _limit;
        }

        public void Reset()
        {
            _start = 0;
            _currIteration = 0;
        }
    }


public class Program {
    static void Main()
    {
        ProgressionFactory factory  = new FibonacciFactory();
        IProgression progression = factory.CreateProgression(10);
        progression.ToList().ForEach(i => Console.WriteLine(i));

        Console.WriteLine("");

        ProgressionFactory factory1 = new ArithmeticFactory();
        IProgression progression1 = factory1.CreateProgression(10);
        progression.ToList().ForEach(i => Console.WriteLine(i));
    }
}
