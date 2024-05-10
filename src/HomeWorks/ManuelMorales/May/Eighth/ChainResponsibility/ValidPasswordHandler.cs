public class ValidPasswordHandler : LoginHandler
{
    public ValidPasswordHandler(Database database)
        : base(database) { }

    public override bool HandleRequest(String userName, String password)
    {
        if (!_database.IsCorrectPassword(userName, password))
        {
            Console.WriteLine("Invalid password");
            return false;
        }

        return base.HandleRequest(userName, password);
    }
}
