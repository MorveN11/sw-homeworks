namespace TwentyOne
{
    class Program
    {
        static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        static void PrintDatabaseInfo(Database database)
        {
            Console.WriteLine("{0} Database:", database.GetType().Name);

            Console.WriteLine("Students took subject eigth semester:");
            PrintEnumerable<Student>(database.GetAllStudentsTookSubjectEigthSemester());

            Console.WriteLine("Carrers with more than ten failed students:");
            PrintEnumerable<Carrer>(database.GetAllCarrersWithMoreThanTenFailedStudents());

            Console.WriteLine("Top ten students:");
            PrintEnumerable<Student>(database.GetTopTenStudents());

            Console.WriteLine("Quantity of approved students per subject:");
            PrintEnumerable<(string, int)>(database.GetQuantityOfApprovedStudentsPerSubject());
        }

        static void Main(string[] args)
        {
            var data = new Data();
            var linQDatabase = new LinQDatabase(data);
            var extensionMethodDatabase = new ExtensionMethodDatabase(data);

            PrintDatabaseInfo(extensionMethodDatabase);
            PrintDatabaseInfo(linQDatabase);
        }
    }
}
