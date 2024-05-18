using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventen
{
    public abstract class Progression : IProgression
    {
        protected IPivot pivot;

        public Progression(IPivot pivot)
        {
            this.pivot = pivot;
        }

        public void Dispose()
        {
            pivot.Dispose();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return pivot;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return pivot;
        }
    }
}
