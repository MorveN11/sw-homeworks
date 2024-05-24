using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{
    public class Study
    {

        public int IdStudent { get; set; }
        public int IdSubject { get; set; }
        public int Grade { get; set; }
        public int Semester { get; set; }

        public Study(int idStudent, int idSubject, int grade, int semester)
        {
            IdStudent = idStudent;
            IdSubject = idSubject;
            Grade = grade;
            Semester = semester;
        }
    }
}
