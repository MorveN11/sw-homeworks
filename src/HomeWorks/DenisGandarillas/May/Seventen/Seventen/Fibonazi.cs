using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventen
{
    public class Fibonazi : IPivot
    {
        public int Limit { get; set; }
        private int first = 0;
        private int second = 1;
        private int current = 0;

        public int Current => first;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (current > 1)
            {
                int aux = first + second;
                first = second;
                second = aux;
            }

            current++;

            return current <= Limit;
        }

        public void Reset()
        {
            first = 0;
            second = 1;
            current = 0;
        }
    }
}
