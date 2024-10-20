namespace shablonP_2;

public class UserManager
{
    private List<User> Users { get; set; } = new();
    public User? CurrentUser { get; set; } = null;

    public void Registration(string login, string password)
    {
        try
        {
            var h1 = new ExistHandler();
            var h2 = new CorrectHandler();
            var h3 = new AvailHandler();
            h1.Successor = h2;
            h2.Successor = h3;

            h1.HandleRequest(login, password, Users, CurrentUser);
            Users.Add(new User(login, password));
            CurrentUser = new User(login, password);
            Console.WriteLine($"Пользователь \"{login}\" зарегистрирован");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Authorisation(string login, string password)
    {
        try
        {
            var h1 = new ExistHandler();
            var h2 = new CorrectHandler();
            var h3 = new ValidHandler();
            h1.Successor = h2;
            h2.Successor = h3;

            h1.HandleRequest(login, password, Users, CurrentUser);
            CurrentUser = new User(login, password);
            Console.WriteLine($"Пользователь \"{login}\" успешно зашел");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Logout()
    {
        try
        {
            if (CurrentUser is null)
            {
                throw new Exception("Вы не вошли в аккаунт");
            }

            CurrentUser = null;
            Console.WriteLine("Вы успешно вышли");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}