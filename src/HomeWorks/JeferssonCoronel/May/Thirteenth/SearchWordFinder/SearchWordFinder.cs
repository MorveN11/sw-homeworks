namespace HomeWorks.JeferssonCoronel.May.Thirteenth.SequenceManager.SequenceManager.cs
{
    // I also use the Strategy Design Pattern

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public interface ISearchStrategy
    {
        List<int> Search(Dictionary<string, List<int>> index, string searchTerm);
    }

    public class ExactWordSearchStrategy : ISearchStrategy
    {
        public List<int> Search(Dictionary<string, List<int>> index, string searchTerm)
        {
            if (index.TryGetValue(searchTerm, out List<int> positions))
                return positions;
            return new List<int>();
        }
    }

    public class PartialWordSearchStrategy : ISearchStrategy
    {
        public List<int> Search(Dictionary<string, List<int>> index, string searchTerm)
        {
            return index.Where(kvp => kvp.Key.Contains(searchTerm))
                        .SelectMany(kvp => kvp.Value)
                        .ToList();
        }
    }

    public class WordSearcher(ISearchStrategy strategy)
    {
        private readonly Dictionary<string, List<int>> _index = new();

        public void SetSearchStrategy(ISearchStrategy searchStrategy)
        {
            strategy = searchStrategy;
        }

        public void BuildIndex(string fileContent)
        {
            string[] words = Regex.Split(fileContent, @"\W+");
            int position = 0;

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    string normalizedWord = word.ToLower();
                    if (!_index.ContainsKey(normalizedWord))
                        _index[normalizedWord] = new List<int>();
                    _index[normalizedWord].Add(position);
                }
                position += word.Length + 1;
            }
        }

        public void SearchInFile(string searchTerm)
        {
            var positions = strategy.Search(_index, searchTerm.ToLower());
            Console.WriteLine(positions.Count > 0
                ? $"Word found at positions: {string.Join(", ", positions)}"
                : "Word not found");
        }
    }

    public static class Program
    {
        private static void Main()
        {
            const string fileContent = "Hello, this is a sample text file\nto test the word search implementation." +
                                       "\nIt includes the word “hello” and the substring “llo”\nso you can try different search strategies." +
                                       "\n\nThe bat and the stork shared a great affection.\nshared a great affection.\nWhen twilight came," +
                                       "\nthey would go out to dance a delicate duet.\n\nYou can find “llo” in multiple words,\nlike “hello”, “fellow”, or “hollow”." +
                                       "\nBut there is only one instance of “hello”.\n\nThe duet of the bat and the stork\nwas heard throughout the valley." +
                                       "\nThey danced with great joy and care,\nuntil the sun rose again.";

            WordSearcher searcher = new WordSearcher(new ExactWordSearchStrategy());
            searcher.BuildIndex(fileContent);

            Console.WriteLine("- ExactWordSearchStrategy: t");
            searcher.SearchInFile("hello");

            Console.WriteLine("\n- PartialWordSearchStrategy: ");
            searcher.SetSearchStrategy(new PartialWordSearchStrategy());
            searcher.SearchInFile("llo");
        }
    }
}
