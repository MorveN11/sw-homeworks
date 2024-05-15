namespace Blog
{public class  WordSearcher{

    private ITokenizer _tokenizer;
    private List<Line> _lines;

    public WordSearcher(ITokenizer tokenizer){
        _tokenizer = tokenizer;
    }

    public void initPreprocessing(string[] data){
        _lines = _tokenizer.Tokenize(data);
    }


    public List<Line> search(string word){


        List<Line> resultLines = new List<Line>();

        foreach (Line line in _lines)
        {
            string lineText = line.text;

            if (lineText.Contains(word.ToLower()))
            {
                resultLines.Add(line);
            }
        }

        return resultLines;
    }
}
}
