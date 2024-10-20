using sh_lab_2;

var userManager = new UserManager();
userManager.Authorisation("12345678", "1234Aa!@");  //вход в несуществующий аккаунт

userManager.Registration("12345678", "1234Aa!@");   //регистрация
userManager.Authorisation("12345678", "1234Aa!@");  //авторизация
userManager.Logout();                               //выход
userManager.Logout();                               //выход из несуществующего аккаунта
userManager.Authorisation("12345678", "1234Aa!@");  //вход обратно
userManager.Authorisation("12345678", "1234Aa!@");  //вход когда уже вошел