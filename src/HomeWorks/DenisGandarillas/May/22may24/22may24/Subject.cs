using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{
    public class Subject
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credit { get; set; }

        public Subject(int id, string name, string code, int credit)
        {
            Id = id;
            Name = name;
            Code = code;
            Credit = credit;
        }
    }
}
