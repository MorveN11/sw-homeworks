using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventen
{
    public class FibonaziProgression : Progression
    {

        public FibonaziProgression(int limit) : base(new Fibonazi { Limit = limit })
        {
        }

    }
}
