using System.Collections;
namespace Progression
{


    public class Progression : IEnumerable<int>
    {
        private int _limit;

        public Progression(int limit){
            _limit = limit;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new Fibonacci(_limit);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Fibonacci : IEnumerator<int>{
        private int _a = 0, _b = 1, _currIteration = 0;
        private int _limit;


        public Fibonacci(int limit){
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



    public class Program {
        static void Main(){
            Progression progression = new Progression(150);
            foreach(int i in progression){
                Console.WriteLine(i);
            }
        }
    }

}
