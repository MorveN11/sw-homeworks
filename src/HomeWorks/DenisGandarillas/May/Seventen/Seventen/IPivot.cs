using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventen
{
    public interface IPivot : IEnumerator<int>
    {

        int Limit { get; set; }

    }
}
