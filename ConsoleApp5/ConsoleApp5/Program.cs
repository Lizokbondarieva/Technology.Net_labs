using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class User
{
    // Властивості для імені користувача та паролю
    public string Username { get; set; }
    public string Password { get; set; }

    // Конструктор для ініціалізації імені та паролю
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    // Метод для виведення інформації про користувача
    public void PrintUserInfo()
    {
        Console.WriteLine($"Ім'я користувача: {Username}");
        Console.WriteLine($"Пароль: {new string('*', Password.Length)}"); // Маскуємо пароль
     
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо у користувача ім'я
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Введіть ім'я користувача: ");
        string username = Console.ReadLine();

        // Запитуємо у користувача пароль
        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();

        // Створюємо об'єкт користувача з введеними даними
        User user = new User(username, password);

        // Виводимо інформацію про користувача
        Console.WriteLine("\nІнформація про користувача:");
        user.PrintUserInfo();

        // Очікуємо натискання клавіші для завершення програми
        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
