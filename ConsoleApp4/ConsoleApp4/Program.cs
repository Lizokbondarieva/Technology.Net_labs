using System;

public class Product
{
    // Властивості для назви товару та його ціни
    public string Name { get; set; }
    public double Price { get; set; }

    // Конструктор для ініціалізації назви та ціни товару
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // Метод для виведення інформації про товар
    public void PrintProductInfo()
    {
        Console.WriteLine($"Назва товару: {Name}, Цiна: {Price} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо користувача про назву товару
        Console.Write("Введiть назву товару: ");
        string name = Console.ReadLine();

        // Запитуємо користувача про ціну товару
        Console.Write("Введiть цiну товару: ");
        double price = Convert.ToDouble(Console.ReadLine());

        // Створення об'єкта товару з введеними користувачем даними
        Product product = new Product(name, price);

        // Виведення інформації про товар
        Console.WriteLine("\nIнформацiя про товар:");
        product.PrintProductInfo();

        // Очікуємо натискання клавіші для завершення програми
        Console.WriteLine("\nНатиснiть будь-яку клавiшу для виходу...");
        Console.ReadKey();
    }
}
