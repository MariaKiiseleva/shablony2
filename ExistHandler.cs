namespace shablonP_2;

public class ExistHandler : Handler
{
    public override void HandleRequest(string login, string password, List<User> users, User? currentUser)
    {
        if (currentUser != null)
        {
            throw new Exception($"Сначало нужно выйти из аккаунта"); ;
        }
        Successor?.HandleRequest(login, password, users, currentUser);
    }
}