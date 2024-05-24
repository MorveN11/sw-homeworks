using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{

    public class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Commercial students taking an eighth semester subject");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("With LINQ");

            var responseL1 = (

                from career in Database.Careers
                join have in Database.Haves on career.Id equals have.IdCareer
                join candidate in Database.Candidates on career.Id equals candidate.IdCareer
                join student in Database.Students on candidate.IdStudent equals student.Id
                where career.Name == "Comercial Engineering" && have.Semester == 8
                select new
                {
                    student.Id,
                    student.Name,
                    student.LastName
                }

            );

            foreach (var item in responseL1)
            {

                Console.WriteLine(item);

            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("With EXTENSION METHODS");

            var responseEM1 = Database.Careers.Join(Database.Haves, career => career.Id, have => have.IdCareer, (career, have) => new
            {
                career.Id,
                career.Name,
                have.Semester
            }).Join(Database.Candidates, first => first.Id, candidate => candidate.IdCareer, (first, candidate) => new
            {
                first.Semester,
                first.Name,
                candidate.IdStudent
            }).Join(Database.Students, first => first.IdStudent, student => student.Id, (first, student) => new
            {
                student.Id,
                student.Name,
                student.LastName,
                first.Semester,
                CareerName = first.Name
            }).Where(final => final.CareerName == "Comercial Engineering" && final.Semester == 8).Select(final => new
            {
                final.Id,
                final.Name,
                final.LastName
            });

            foreach (var item in responseEM1)
            {

                Console.WriteLine(item);

            }

            Console.WriteLine("============================================================");
            Console.WriteLine("List of careers with more than 10 deferred students");
            Console.WriteLine("============================================================");
            Console.WriteLine("With LINQ");

            var responseL2 = (

                from career in Database.Careers
                join candidate in Database.Candidates on career.Id equals candidate.IdCareer
                join student in Database.Students on candidate.IdStudent equals student.Id
                group student by career into careerGroup
                where careerGroup.Count() > 10
                select new
                {
                    careerGroup.Key.Id,
                    careerGroup.Key.Name
                }

            );

            foreach (var item in responseL2)
            {

                Console.WriteLine(item);

            }

        }

    }

}
