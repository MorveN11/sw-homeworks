using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    // 1. List of "Commercial" students who took an 8th semester subject.
    var response = (
      from student in Database.Students
      join candidate in Database.Candidates on student.Id equals candidate.IdStudent
      join career in Database.Careers on candidate.IdCareer equals career.Id
      join study in Database.Studies on student.Id equals study.IdStudent
      join have in Database.Have on study.IdSubject equals have.IdSubject
      where career.Name == "Comercial" && have.Semester == 8
      select new {
        student.Name,
        student.Lastname
      }).Distinct().ToList();
    
    Console.WriteLine("1. Lista de estudiantes de \"Comercial\" que tomaron una materia de 8vo semestre");
    foreach (var s in response)
    {
      Console.WriteLine($"Linq: {s.Name} {s.Lastname}");
    }

    var response1 = Database.Students
      .Join(Database.Candidates,
        student => student.Id,
        candidate => candidate.IdStudent,
        (student, candidate) => new { student, candidate })
      .Join(Database.Careers,
        sc => sc.candidate.IdCareer,
        career => career.Id,
        (sc, career) => new { sc.student, sc.candidate, career })
      .Join(Database.Studies,
        scc => scc.student.Id,
        study => study.IdStudent,
        (scc, study) => new { scc.student, scc.career, study })
      .Join(Database.Have,
        sccs => sccs.study.IdSubject,
        have => have.IdSubject,
        (sccs, have) => new { sccs.student, sccs.career, sccs.study, have })
      .Where(sccsh => sccsh.career.Name == "Comercial" && sccsh.have.Semester == 8)
      .Select(sccsh => new { sccsh.student.Name, sccsh.student.Lastname })
      .Distinct()
      .ToList();

    foreach (var s in response1)
    {
      Console.WriteLine($"Extension method: {s.Name} {s.Lastname}");
    }
    
    Console.WriteLine("");
    
    // 2. List of careers with more than 10 deferred students   
    var response2 = (
      from study in Database.Studies
      join student in Database.Students on study.IdStudent equals student.Id
      join candidate in Database.Candidates on student.Id equals candidate.IdStudent
      join career in Database.Careers on candidate.IdCareer equals career.Id
      where study.Grade < 60
      group student by career.Name into careerGroup
      where careerGroup.Count() > 10
      select new {
        CareerName = careerGroup.Key,
        Count = careerGroup.Count()
      }).ToList();
    
    Console.WriteLine("2. Lista de carreras con mas de 10 estudiantes aplazados");
    foreach (var s in response2)
    {
      Console.WriteLine($"Linq: {s.CareerName} - {s.Count} aplazado(s)");
    }

    var response3 = Database.Studies
      .Join(Database.Students,
        study => study.IdStudent,
        student => student.Id,
        (study, student) => new { study, student })
      .Join(Database.Candidates,
        ss => ss.student.Id,
        candidate => candidate.IdStudent,
        (ss, candidate) => new { ss.study, ss.student, candidate })
      .Join(Database.Careers,
        ssc => ssc.candidate.IdCareer,
        career => career.Id,
        (ssc, career) => new { ssc.study, ssc.student, career })
      .Where(s => s.study.Grade < 60)
      .GroupBy(ssc => ssc.career.Name)
      .Where(g => g.Count() > 10)
      .Select(g => new { CareerName = g.Key, Count = g.Count() })
      .ToList();

    foreach (var s in response3)
    {
      Console.WriteLine($"Extension method: {s.CareerName} - {s.Count} aplazado(s)");
    }

    Console.WriteLine("");

    // 3. Top 10 best students
    var response4 = (
      from student in Database.Students
      join study in Database.Studies on student.Id equals study.IdStudent
      group new { student, study } by new { student.Id, student.Name, student.Lastname } into studentGroup
      let averageGrade = Math.Round(studentGroup.Average(s => s.study.Grade), 2)
      orderby averageGrade descending
      select new {
        studentGroup.Key.Name,
        studentGroup.Key.Lastname,
        AverageGrade = averageGrade
      }).Take(10).ToList();

    Console.WriteLine("3. El Top 10 mejores estudiantes");
    foreach (var s in response4)
    {
      Console.WriteLine($"Linq: {s.Name} {s.Lastname} - {s.AverageGrade}");
    }

    var response5 = Database.Students
      .Join(Database.Studies,
        student => student.Id,
        study => study.IdStudent,
        (student, study) => new { student, study })
      .GroupBy(ss => new { ss.student.Id, ss.student.Name, ss.student.Lastname })
      .Select(g => new { g.Key.Name, g.Key.Lastname, AverageGrade = Math.Round(g.Average(ss => ss.study.Grade), 2) })
      .OrderByDescending(s => s.AverageGrade)
      .Take(10)
      .ToList();

    foreach (var s in response5)
    {
      Console.WriteLine($"Extension method: {s.Name} {s.Lastname} - {s.AverageGrade}");
    }
    
    Console.WriteLine("");
    
    // 4. The number of students passed per subject   
    var response6 = (
      from study in Database.Studies
      join subject in Database.Subjects on study.IdSubject equals subject.Id
      where study.Grade >= 60
      group study by new { study.IdSubject, subject.Name } into subjectGroup
      select new {
        subjectGroup.Key.Name,
        ApprovedCount = subjectGroup.Count()
      }).ToList();

    Console.WriteLine("4. La cantidad de estudiantes aprobados por materia");
    foreach (var s in response6)
    {
      Console.WriteLine($"Linq: {s.Name} - {s.ApprovedCount}");
    }

    var response7 = Database.Studies
      .Join(Database.Subjects,
        study => study.IdSubject,
        subject => subject.Id,
        (study, subject) => new { study, subject.Name })
      .Where(s => s.study.Grade >= 60)
      .GroupBy(ss => new { ss.study.IdSubject, ss.Name })
      .Select(g => new { g.Key.Name, ApprovedCount = g.Count() })
      .ToList();

    foreach (var s in response7)
    {
      Console.WriteLine($"Extension method: {s.Name} - {s.ApprovedCount}");
    }
  }
}
