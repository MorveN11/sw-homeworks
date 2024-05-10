public class Database
{
    private readonly Dictionary<String, String> _users;

    public Database()
    {
        _users = new Dictionary<String, String>();
        _users.Add("admin", "admin");
        _users.Add("user", "user");
    }

    public bool IsValidUser(String userName, String password)
    {
        return _users.ContainsKey(userName);
    }

    public bool IsCorrectPassword(String userName, String password)
    {
        return _users.ContainsKey(userName) && _users[userName] == password;
    }
}
