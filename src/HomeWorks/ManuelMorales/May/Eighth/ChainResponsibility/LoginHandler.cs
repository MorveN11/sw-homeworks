public class LoginHandler
{
    private LoginHandler? _succesor;

    protected Database _database;

    public LoginHandler(Database database)
    {
        _database = database;
    }

    public LoginHandler SetSuccessor(LoginHandler successor)
    {
        _succesor = successor;
        return this;
    }

    public virtual bool HandleRequest(String userName, String password)
    {
        return _succesor?.HandleRequest(userName, password) ?? true;
    }
}
