namespace shablonP_2;

public class CorrectHandler : Handler
{
    public override void HandleRequest(string login, string password, List<User> users, User? currentUser)
    {
        if (login.Length >= 8
            && !login.Any(char.IsPunctuation))
        {
            if (password.Length >= 8
                && password.Any(char.IsLetter)
                && password.Any(char.IsDigit)
                && password.Any(char.IsPunctuation))
            {
                Successor?.HandleRequest(login, password, users, currentUser);
                return;
            }
            throw new Exception($"Пароль \"{password}\" не верный");
        }
        throw new Exception($"Логин \"{login}\" не верный");
    }
}