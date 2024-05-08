using System;
using System.Collections.Generic;

public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double Capacity { get; }
    public abstract double Range { get; }

    public abstract double GetSpeed();
    public abstract double GetCapacity();
    public abstract double GetRange();
}

public abstract class Car : Transport
{
    public override double Speed { get; }
    public override double Capacity { get; }
    public override double Range { get; }

    public override double GetSpeed() => Speed;
    public override double GetCapacity() => Capacity;
    public override double GetRange() => Range;
}

public abstract class Airplane : Transport
{
    public override double Speed { get; }
    public override double Capacity { get; }
    public override double Range { get; }

    public override double GetSpeed() => Speed;
    public override double GetCapacity() => Capacity;
    public override double GetRange() => Range;
}

// Абстрактный класс "Корабль"
public abstract class Ship : Transport
{
    public override double Speed { get; }
    public override double Capacity { get; }
    public override double Range { get; }

    public override double GetSpeed() => Speed;
    public override double GetCapacity() => Capacity;
    public override double GetRange() => Range;
}

// Конкретный класс "Легковой автомобиль"
public class PassengerCar : Car
{
    public override double Speed { get; } = 120.0;
    public override double Capacity { get; } = 500.0;
    public override double Range { get; } = 500.0;

    public override string ToString()
    {
        return $"Легковой автомобиль грузоподъемностью {GetCapacity()} может проехать {GetRange()}";
    }
}

public class Airplane1 : Airplane
{
    public override double Speed { get; } = 800.0;
    public override double Capacity { get; } = 10000.0;
    public override double Range { get; } = 5000.0;

    public override string ToString()
    {
        return $"Самолет грузоподъемностью {GetCapacity()} может пролететь {GetRange()}";
    }
}

public class Ship1 : Ship
{
    public override double Speed { get; } = 20.0;
    public override double Capacity { get; } = 10000.0;
    public override double Range { get; } = 10000.0;

    public override string ToString()
    {
        return $"Корабль грузоподъемностью {GetCapacity()} может проплыть {GetRange()}";
    }
}

public class User
{
    private string _login;
    private string _password;

    public User(string login, string password)
    {
        _login = login;
        _password = password;
    }

    public string Login
    {
        get { return _login; }
    }

    public string Password
    {
        get { return _password; }
    }
}

// Класс "Менеджер пользователей"
public class UserManager
{
    private List<User> _users;

    public UserManager()
    {
        _users = new List<User>();
    }

    public void RegisterUser(string login, string password)
    {
        User user = new User(login, password);
        _users.Add(user);
    }

    public bool Login(string login, string password)
    {
        foreach (var user in _users)
        {
            if (user.Login == login && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserManager userManager = new UserManager();

        userManager.RegisterUser("user1", "password1");
        userManager.RegisterUser("user2", "password2");
        userManager.RegisterUser("user3", "password3");

        Console.WriteLine("Вход в систему:");
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        if (userManager.Login(login, password))
        {
            Console.WriteLine("Вход выполнен успешно!");
        }
        else
        {
            Console.WriteLine("Неверный логин или пароль.");
        }
    }
}
