using System.IO;
namespace IOUTils{

        public class FileReader{
            public static string[] ReadFile(string path){
                string[] lines = File.ReadAllLines(path);
                return lines;
            }
        }
}