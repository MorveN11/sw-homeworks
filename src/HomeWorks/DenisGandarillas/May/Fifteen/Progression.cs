using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    public class Progression : IEnumerable<int>
    {

        private int _limit;

        public Progression(int limit)
        {
            this._limit = limit;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new Fibonazi(_limit);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
