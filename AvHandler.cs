namespace shablonP_2;

public class AvailHandler : Handler
{
    public override void HandleRequest(string login, string password, List<User> users, User? currentUser)
    {
        if (users.Any(t => t.Login == login))
        {
            throw new Exception($"Логин \"{login}\" уже используется");
        }

        Successor?.HandleRequest(login, password, users, currentUser);
    }
}