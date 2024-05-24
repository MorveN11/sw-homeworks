using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{
    public class Candidate
    {

        public int IdStudent { get; set; }
        public int IdCareer { get; set; }

        public Candidate(int idStudent, int idCareer)
        {

            IdStudent = idStudent;
            IdCareer = idCareer;

        }

    }
}
