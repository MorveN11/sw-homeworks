using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{
    public class Career
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Career(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
