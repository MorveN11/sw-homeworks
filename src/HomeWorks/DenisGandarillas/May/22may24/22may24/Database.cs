using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22may24
{
    public static class Database
    {

        public static List<Student> Students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Flor",
                LastName = "Luizaga"
            },

            new Student
            {
                Id = 2,
                Name = "Denis",
                LastName = "Gandarillas"
            },
            new Student
            {
                Id = 3,
                Name = "Camila",
                LastName = "Perez"
            },
            new Student
            {
                Id = 4,
                Name = "Rissel",
                LastName = "Antezana"
            },
            new Student
            {
                Id = 5,
                Name = "Alison",
                LastName = "Mendizabal"
            },
            new Student
            {
                Id = 6,
                Name = "Joel",
                LastName = "Medrano"
            },
            new Student
            {
                Id = 7,
                Name = "Gabriela",
                LastName = "Vargas"
            }
        };

        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject(1, "Microeconomics", "ECON101", 3),
            new Subject(2, "Macroeconomics", "ECON102", 3),
            new Subject(3, "Financial Accounting", "ACCT201", 4),
            new Subject(4, "Corporate Finance", "FIN301", 4),
            new Subject(5, "Business Law", "LAW101", 3),
            new Subject(6, "Marketing Management", "MKTG201", 3),
            new Subject(7, "Strategic Management", "MGMT301", 4),
            new Subject(8, "Operations Management", "OPM302", 3),
            new Subject(9, "Civil Law I", "LAW201", 4),
            new Subject(10, "Civil Law II", "LAW202", 4),
            new Subject(11, "Constitutional Law", "LAW301", 4),
            new Subject(12, "Criminal Law", "LAW401", 4),
            new Subject(13, "Administrative Law", "LAW402", 3),
            new Subject(14, "International Law", "LAW403", 3),
            new Subject(15, "Environmental Law", "LAW404", 3),
            new Subject(16, "Architectural Design I", "ARCH101", 5),
            new Subject(17, "Architectural Design II", "ARCH102", 5),
            new Subject(18, "Construction Technology", "ARCH201", 4),
            new Subject(19, "Urban Planning", "ARCH301", 3),
            new Subject(20, "Building Materials", "ARCH302", 3),
            new Subject(21, "History of Architecture", "ARCH401", 3),
            new Subject(22, "Structures I", "ARCH402", 4),
            new Subject(23, "Structures II", "ARCH403", 4),
            new Subject(24, "Human Anatomy", "MED101", 5),
            new Subject(25, "Physiology", "MED102", 5),
            new Subject(26, "Biochemistry", "MED201", 4),
            new Subject(27, "Pathology", "MED202", 4),
            new Subject(28, "Pharmacology", "MED301", 4),
            new Subject(29, "Microbiology", "MED302", 4),
            new Subject(30, "Internal Medicine", "MED401", 5),
            new Subject(31, "Surgery", "MED402", 5),
            new Subject(32, "Pediatrics", "MED403", 4),
            new Subject(33, "Obstetrics and Gynecology", "MED404", 4),
            new Subject(34, "Tourism Management", "TOUR101", 3),
            new Subject(35, "Hospitality Management", "TOUR102", 3),
            new Subject(36, "Sustainable Tourism", "TOUR201", 3),
            new Subject(37, "Cultural Heritage", "TOUR202", 3),
            new Subject(38, "Event Management", "TOUR301", 3),
            new Subject(39, "Tourism Marketing", "TOUR302", 3),
            new Subject(40, "Tourism Economics", "TOUR303", 3),
            new Subject(41, "Travel Agency Management", "TOUR401", 3),
            new Subject(42, "Tourist Behavior", "TOUR402", 3),
            new Subject(43, "Software Development I", "CS101", 4),
            new Subject(44, "Software Development II", "CS102", 4),
            new Subject(45, "Database Systems", "CS201", 4),
            new Subject(46, "Operating Systems", "CS301", 4),
            new Subject(47, "Computer Networks", "CS302", 4),
            new Subject(48, "Algorithms and Data Structures", "CS401", 4),
            new Subject(49, "Artificial Intelligence", "CS402", 4),
            new Subject(50, "Machine Learning", "CS403", 4),
            new Subject(51, "Data Mining", "CS404", 4),
            new Subject(52, "Project Management", "MGMT402", 3),
            new Subject(53, "Supply Chain Management", "OPM401", 3),
            new Subject(54, "E-commerce", "MKTG402", 3),
            new Subject(55, "Digital Marketing", "MKTG403", 3),
            new Subject(56, "Consumer Behavior", "MKTG404", 3),
            new Subject(57, "Investment Analysis", "FIN402", 4),
            new Subject(58, "Financial Markets", "FIN403", 4),
            new Subject(59, "Risk Management", "FIN404", 4),
            new Subject(60, "Corporate Governance", "MGMT403", 3),
            new Subject(61, "Software Development V", "CS105", 4),
            new Subject(62, "E-commerce II", "MKTG403", 3)
        };

        public static List<Career> Careers = new List<Career>
        {
            new Career(1, "Software Engineering"),
            new Career(2, "Architecture"),
            new Career(3, "Law"),
            new Career(4, "Comercial Engineering"),
            new Career(5, "Medicine"),
            new Career(6, "Tourism")
        };

        public static List<Have> Haves = new List<Have>
        {
            new Have(1, 4, 1),
            new Have(2, 4, 2),
            new Have(3, 4, 3),
            new Have(4, 4, 4),
            new Have(5, 4, 2),
            new Have(6, 4, 3),
            new Have(7, 4, 5),
            new Have(8, 4, 6),
            new Have(9, 3, 1),
            new Have(10, 3, 2),
            new Have(11, 3, 3),
            new Have(12, 3, 4),
            new Have(13, 3, 5),
            new Have(14, 3, 6),
            new Have(15, 3, 7),
            new Have(16, 2, 1),
            new Have(17, 2, 2),
            new Have(18, 2, 3),
            new Have(19, 2, 4),
            new Have(20, 2, 5),
            new Have(21, 2, 6),
            new Have(22, 2, 7),
            new Have(23, 2, 8),
            new Have(24, 5, 1),
            new Have(25, 5, 2),
            new Have(26, 5, 3),
            new Have(27, 5, 4),
            new Have(28, 5, 5),
            new Have(29, 5, 6),
            new Have(30, 5, 7),
            new Have(31, 5, 8),
            new Have(32, 5, 9),
            new Have(33, 5, 10),
            new Have(34, 6, 1),
            new Have(35, 6, 2),
            new Have(36, 6, 3),
            new Have(37, 6, 4),
            new Have(38, 6, 5),
            new Have(39, 6, 6),
            new Have(40, 6, 7),
            new Have(41, 6, 8),
            new Have(42, 6, 9),
            new Have(43, 1, 1),
            new Have(44, 1, 2),
            new Have(45, 1, 3),
            new Have(46, 1, 4),
            new Have(47, 1, 5),
            new Have(48, 1, 6),
            new Have(49, 1, 7),
            new Have(50, 1, 8),
            new Have(51, 1, 9),
            new Have(61, 1, 10),
            new Have(62, 4, 8)
        };

        public static List<Study> Studies = new List<Study>
        {
            new Study(1, 1, 90, 1),
            new Study(1, 16, 85, 1),
            new Study(2, 43, 88, 1),
            new Study(2, 44, 92, 2),
            new Study(3, 9, 75, 1),
            new Study(3, 10, 78, 2),
            new Study(4, 24, 89, 1),
            new Study(4, 25, 93, 2),
            new Study(5, 1, 86, 1),
            new Study(5, 6, 82, 1),
            new Study(6, 24, 87, 1),
            new Study(6, 25, 90, 2),
            new Study(7, 34, 84, 1),
            new Study(7, 35, 88, 2),
            new Study(2, 45, 90, 3),
            new Study(2, 46, 91, 3),
            new Study(3, 11, 80, 3),
            new Study(3, 12, 85, 4),
            new Study(4, 26, 92, 3),
            new Study(4, 27, 94, 4),
            new Study(5, 8, 88, 3),
            new Study(5, 5, 82, 3),
            new Study(6, 26, 91, 3),
            new Study(6, 27, 93, 4),
            new Study(7, 36, 87, 3),
            new Study(7, 37, 89, 4),
            new Study(1, 18, 84, 2),
            new Study(1, 19, 86, 3),
            new Study(1, 20, 88, 4),
            new Study(1, 16, 45, 1),
            new Study(2, 43, 50, 1),
            new Study(2, 44, 49, 2),
            new Study(3, 9, 48, 1),
            new Study(3, 10, 47, 2),
            new Study(4, 24, 46, 1),
            new Study(4, 25, 45, 2),
            new Study(5, 1, 50, 1),
            new Study(5, 6, 49, 1),
            new Study(6, 24, 48, 1),
            new Study(6, 25, 47, 2),
            new Study(7, 34, 46, 1),
            new Study(7, 35, 45, 2),
            new Study(2, 45, 50, 3),
            new Study(2, 46, 49, 3),
            new Study(3, 11, 48, 3),
            new Study(3, 12, 47, 4)
        };

        public static List<Candidate> Candidates = new List<Candidate>
        {
            new Candidate(1, 2),
            new Candidate(2, 1),
            new Candidate(3, 3),
            new Candidate(4, 5),
            new Candidate(5, 4),
            new Candidate(6, 5),
            new Candidate(7, 6)
        };
    }
}
