namespace shablonP_2;

public class ValidHandler : Handler
{
    public override void HandleRequest(string login, string password, List<User> users, User? currentUser)
    {
        if (users.All(user => user.Login != login && user.Password != password))
        {
            throw new Exception($"\"{login}\" не известен");
        }

        Successor?.HandleRequest(login, password, users, currentUser);
    }
}