public class AuthService
{
    private readonly LoginHandler _handler;

    public AuthService(LoginHandler handler)
    {
        _handler = handler;
    }

    public bool Login(String userName, String password)
    {
        if (_handler.HandleRequest(userName, password))
        {
            Console.WriteLine($"User {userName} logged in");
            return true;
        }

        Console.WriteLine($"User {userName} not logged in");
        return false;
    }
}
