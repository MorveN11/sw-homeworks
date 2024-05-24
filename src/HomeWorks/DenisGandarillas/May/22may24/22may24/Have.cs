using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{
    public class Have
    {

        public int IdSubject { get; set; }
        public int IdCareer { get; set; }
        public int Semester { get; set; }

        public Have(int idSubject, int idCareer, int semester)
        {
            IdSubject = idSubject;
            IdCareer = idCareer;
            Semester = semester;
        }
    }
}
