public static class Database
{
    public static List<Student> Students = new List<Student>
    {
        new Student{Id = 1, Name = "Miguel", Lastname = "Ramirez"},
        new Student{Id = 2, Name = "Diana", Lastname = "Lopez"},
        new Student{Id = 3, Name = "Carlos", Lastname = "Sanchez"},
        new Student{Id = 4, Name = "Andrea", Lastname = "Martinez"},
        new Student{Id = 5, Name = "Mario", Lastname = "Diaz"},
        new Student{Id = 6, Name = "Elena", Lastname = "Morales"},
        new Student{Id = 7, Name = "Rosa", Lastname = "Ruiz"},
        new Student{Id = 8, Name = "Valeria", Lastname = "Castro"},
        new Student{Id = 9, Name = "Jorge", Lastname = "Ortiz"},
        new Student{Id = 10, Name = "Luisa", Lastname = "Suarez"},
        new Student{Id = 11, Name = "Teresa", Lastname = "Pineda"},
        new Student{Id = 12, Name = "Julia", Lastname = "Arce"},
        new Student{Id = 13, Name = "Samuel", Lastname = "Guerra"},
        new Student{Id = 14, Name = "Felipe", Lastname = "Vega"},
        new Student{Id = 15, Name = "Monica", Lastname = "Cortez"},
        new Student{Id = 16, Name = "Pablo", Lastname = "Navarro"},
        new Student{Id = 17, Name = "Oscar", Lastname = "Ramos"},
        new Student{Id = 18, Name = "Ricardo", Lastname = "Vargas"},
        new Student{Id = 19, Name = "Carolina", Lastname = "Bermudez"},
        new Student{Id = 20, Name = "Daniela", Lastname = "Ortega"}
    };

    public static List<Subject> Subjects = new List<Subject>
    {
        new Subject{Id = 1, Name = "Economía", Code = 104, Credit = 3},
        new Subject{Id = 2, Name = "Administración", Code = 105, Credit = 3},
        new Subject{Id = 3, Name = "Contabilidad Avanzada", Code = 106, Credit = 4},
        new Subject{Id = 4, Name = "Álgebra", Code = 207, Credit = 4},
        new Subject{Id = 5, Name = "Física Moderna", Code = 208, Credit = 3},
        new Subject{Id = 6, Name = "Circuitos", Code = 209, Credit = 3},
        new Subject{Id = 7, Name = "Genética", Code = 304, Credit = 4},
        new Subject{Id = 8, Name = "Química Inorgánica", Code = 305, Credit = 4},
        new Subject{Id = 9, Name = "Estadística", Code = 306, Credit = 4}
    };

    public static List<Study> Studies = new List<Study>
    {
        new Study{IdStudent = 1, IdSubject = 1, Grade = 78, Semester = 8},
        new Study{IdStudent = 1, IdSubject = 2, Grade = 65, Semester = 8},
        new Study{IdStudent = 1, IdSubject = 3, Grade = 82, Semester = 8},
        new Study{IdStudent = 3, IdSubject = 1, Grade = 90, Semester = 8},
        new Study{IdStudent = 3, IdSubject = 2, Grade = 88, Semester = 8},
        new Study{IdStudent = 3, IdSubject = 3, Grade = 75, Semester = 8},
        new Study{IdStudent = 6, IdSubject = 1, Grade = 50, Semester = 8},
        new Study{IdStudent = 6, IdSubject = 2, Grade = 60, Semester = 8},
        new Study{IdStudent = 6, IdSubject = 3, Grade = 68, Semester = 8},
        new Study{IdStudent = 8, IdSubject = 1, Grade = 55, Semester = 8},
        new Study{IdStudent = 8, IdSubject = 2, Grade = 62, Semester = 8},
        new Study{IdStudent = 8, IdSubject = 3, Grade = 48, Semester = 8},
        new Study{IdStudent = 12, IdSubject = 1, Grade = 95, Semester = 8},
        new Study{IdStudent = 12, IdSubject = 2, Grade = 85, Semester = 8},
        new Study{IdStudent = 12, IdSubject = 3, Grade = 90, Semester = 8},
        new Study{IdStudent = 13, IdSubject = 1, Grade = 42, Semester = 8},
        new Study{IdStudent = 13, IdSubject = 2, Grade = 40, Semester = 8},
        new Study{IdStudent = 14, IdSubject = 1, Grade = 55, Semester = 8},
        new Study{IdStudent = 14, IdSubject = 2, Grade = 58, Semester = 8},
        new Study{IdStudent = 15, IdSubject = 1, Grade = 65, Semester = 8},
        new Study{IdStudent = 15, IdSubject = 2, Grade = 60, Semester = 8},
        new Study{IdStudent = 16, IdSubject = 1, Grade = 52, Semester = 8},
        new Study{IdStudent = 16, IdSubject = 2, Grade = 55, Semester = 8},
        new Study{IdStudent = 17, IdSubject = 1, Grade = 57, Semester = 8},
        new Study{IdStudent = 17, IdSubject = 2, Grade = 60, Semester = 8},
        new Study{IdStudent = 18, IdSubject = 1, Grade = 59, Semester = 8},
        new Study{IdStudent = 18, IdSubject = 2, Grade = 55, Semester = 8},
        new Study{IdStudent = 19, IdSubject = 1, Grade = 47, Semester = 8},
        new Study{IdStudent = 19, IdSubject = 2, Grade = 50, Semester = 8},
        new Study{IdStudent = 20, IdSubject = 1, Grade = 60, Semester = 8},
        new Study{IdStudent = 20, IdSubject = 2, Grade = 55, Semester = 8},

        new Study{IdStudent = 2, IdSubject = 4, Grade = 75, Semester = 7},
        new Study{IdStudent = 2, IdSubject = 5, Grade = 78, Semester = 7},
        new Study{IdStudent = 5, IdSubject = 4, Grade = 55, Semester = 6},
        new Study{IdStudent = 5, IdSubject = 6, Grade = 60, Semester = 6},
        new Study{IdStudent = 10, IdSubject = 4, Grade = 88, Semester = 6},
        new Study{IdStudent = 10, IdSubject = 6, Grade = 92, Semester = 6},

        new Study{IdStudent = 4, IdSubject = 7, Grade = 90, Semester = 6},
        new Study{IdStudent = 4, IdSubject = 8, Grade = 85, Semester = 6},
        new Study{IdStudent = 7, IdSubject = 7, Grade = 65, Semester = 7},
        new Study{IdStudent = 7, IdSubject = 8, Grade = 62, Semester = 7},
        new Study{IdStudent = 9, IdSubject = 7, Grade = 80, Semester = 7},
        new Study{IdStudent = 11, IdSubject = 8, Grade = 75, Semester = 7}
    };

    public static List<Career> Careers = new List<Career>
    {
        new Career{Id = 1, Name = "Comercial"},
        new Career{Id = 2, Name = "Ingeniería"},
        new Career{Id = 3, Name = "Ciencias"}
    };

    public static List<Candidates> Candidates = new List<Candidates>
    {
        new Candidates{IdStudent = 1, IdCareer = 1},
        new Candidates{IdStudent = 2, IdCareer = 2},
        new Candidates{IdStudent = 3, IdCareer = 1},
        new Candidates{IdStudent = 4, IdCareer = 3},
        new Candidates{IdStudent = 5, IdCareer = 2},
        new Candidates{IdStudent = 6, IdCareer = 1},
        new Candidates{IdStudent = 7, IdCareer = 3},
        new Candidates{IdStudent = 8, IdCareer = 1},
        new Candidates{IdStudent = 9, IdCareer = 3},
        new Candidates{IdStudent = 10, IdCareer = 2},
        new Candidates{IdStudent = 11, IdCareer = 3},
        new Candidates{IdStudent = 12, IdCareer = 1},
        new Candidates{IdStudent = 13, IdCareer = 1},
        new Candidates{IdStudent = 14, IdCareer = 1},
        new Candidates{IdStudent = 15, IdCareer = 1},
        new Candidates{IdStudent = 16, IdCareer = 1},
        new Candidates{IdStudent = 17, IdCareer = 1},
        new Candidates{IdStudent = 18, IdCareer = 1},
        new Candidates{IdStudent = 19, IdCareer = 1},
        new Candidates{IdStudent = 20, IdCareer = 1}
    };

    public static List<Have> Have = new List<Have>
    {
        new Have{Semester = 8, IdSubject = 1, IdCareer = 1},
        new Have{Semester = 8, IdSubject = 2, IdCareer = 1},
        new Have{Semester = 8, IdSubject = 3, IdCareer = 1},
        new Have{Semester = 7, IdSubject = 4, IdCareer = 2},
        new Have{Semester = 6, IdSubject = 5, IdCareer = 2},
        new Have{Semester = 6, IdSubject = 6, IdCareer = 2},
        new Have{Semester = 6, IdSubject = 7, IdCareer = 3},
        new Have{Semester = 7, IdSubject = 8, IdCareer = 3}
    };
}
