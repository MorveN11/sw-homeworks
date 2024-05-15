using System;
using System.IO;

namespace Blog
{
    public class TxtFileReader : IFileReader
    {
        public string[] Read(string path)
        {
            try
            {
                return this.readByLine(path); // Corregido el llamado a readByLine
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo '{path}': {ex.Message}");
            }
        }

        private string[] readByLine(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }
            else
            {
                throw new FileNotFoundException($"El archivo '{path}' no existe.");
            }
        }
    }
}
