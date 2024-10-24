using System;
using System.Collections.Generic;
class User
{
    public string username;
    private string email;
    private string password;
    private string phoneNumber;
    private string lastLoginTime;
    private string birthDate;

    public User(string username, string email, string password, string phoneNumber)
    {
        this.username = username;
        this.email = email;
        this.password = password;
        this.phoneNumber = phoneNumber;
        this.lastLoginTime = string.Empty;
        this.birthDate = string.Empty;
    }
    public bool Authenticate(string login, string password)
    {
        if (this.username == login && this.password == password)
        {
            lastLoginTime = DateTime.Now.ToString();
            return true;
        }
        return false;
    }

    public bool ChangePassword(string phoneNumber, string newPassword)
    {
        if (this.phoneNumber == phoneNumber)
        {
            this.password = newPassword;
            return true;
        }
        return false;
    }
    public bool AddBirthDate(string dateOfBirth)
    {
        if (string.IsNullOrEmpty(birthDate))
        {
            birthDate = dateOfBirth;
            return true;
        }
        else
        {
            Console.WriteLine("Дата рождения уже добавлена.");
            return false;
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Логин: {username}");
        Console.WriteLine($"Почта: {email}");
        Console.WriteLine($"Номер телефона: {phoneNumber}");
        Console.WriteLine($"Время последнего захода: {lastLoginTime}");
        Console.WriteLine($"Дата рождения: {birthDate}");
    }
}
class Program 
{ 
    static void Main()
    {
        Dictionary<string, User> users = new Dictionary<string, User>();
        User user1 = new User("username1", "user1@example.com", "password123", "1234567890");
        users.Add(user1.username, user1);
        bool isAuthenticated = users["username1"].Authenticate("username1", "password123");
        Console.WriteLine("Аутентификация успешна: " + isAuthenticated);
        bool isPasswordChanged = users["username1"].ChangePassword("1234567890", "newpassword456");
        Console.WriteLine("Пароль изменен: " + isPasswordChanged);
        bool isBirthDateAdded = users["username1"].AddBirthDate("01/01/1990");
        Console.WriteLine("Дата рождения добавлена: " + isBirthDateAdded);
        users["username1"].ShowInfo();
        users["username1"].AddBirthDate("02/02/1990");
    }
}