using System;
using System.Collections.Generic;
class User
{
    public string username;

    public User(string username) => this.username1 = username;

    private string email;
    private string password;
    private string phoneNumber;
    private string lastLoginTime;
    private string birthDate;
    private string username1;

    public User(string username, string email, string password, string phoneNumber)
    {
        this.username1 = username;
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

