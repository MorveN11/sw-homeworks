public class App
{
    static void Main(String[] args)
    {
        Database database = new Database();

        LoginHandler loginHandler = new UserExistsHandler(database).SetSuccessor(
            new ValidPasswordHandler(database)
        );

        AuthService authService = new AuthService(loginHandler);

        authService.Login("manuel", "1234");
        authService.Login("admin", "admin");
        authService.Login("user", "123");
        authService.Login("user", "user");
    }
}
