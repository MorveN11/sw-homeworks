namespace Blog
{public class FileReader{


    private IFileReader _fileReader;


    public FileReader(IFileReader fileReader){
        _fileReader = fileReader;
    }


    public string[] read(string path){
        return _fileReader.Read(path);
    }
}
}
