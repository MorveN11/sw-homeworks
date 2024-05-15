
namespace Blog
{public class ProgramController
{
    private IFileReader _fileReader;

    private WordSearcher _wordSearcher;
    public ProgramController(IFileReader fileReader){
        _fileReader = fileReader;
        _wordSearcher = new WordSearcher(new Tokenizer());
    }

    public void start(){
        startFilePreprocessing();
        startWordSearch();

    }


    private void startFilePreprocessing(){
         Console.WriteLine("Insert the path of the file: ");

        string path = Console.ReadLine();

        string[] data = _fileReader.Read(path);

        _wordSearcher.initPreprocessing(data);
    }


    private void startWordSearch(){
        bool continueSearching = true;
        do{

            searchWords();
            Console.WriteLine("Do you want to continue searching? (y/n)");
            string answer = Console.ReadLine();
            if(answer == "n"){
                continueSearching = false;
            }

        }while(continueSearching);
    }

    private void searchWords(){
            Console.WriteLine("Insert the word to search: ");
            string word = Console.ReadLine();
            List<Line> sentences = _wordSearcher.search(word);

            foreach (Line sentence in sentences){
                Console.WriteLine($"{sentence.line} {sentence.text}");
            }
    }
}
}
