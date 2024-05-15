using System;
using System.Collections.Generic;

namespace Blog
{public class Tokenizer : ITokenizer{
    public List<Line> Tokenize(string[] data){
        List<Line> sentences = new List<Line>();
        uint lineNumber = 1;
        foreach (string sentence in data)
        {
            sentences.Add(new Line(lineNumber,  sentence.ToLower().Trim() ));
            lineNumber++;
        }

        return sentences;
    }
}
}
