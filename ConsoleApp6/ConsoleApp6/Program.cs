using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // Функція з двома параметрами-посиланнями
    static void ModifyValues(ref int a, ref int b)
    {
        a += 1;  // Збільшуємо перший параметр на 1
        b -= 2;  // Зменшуємо другий параметр на 2
    }

    static void Main(string[] args)
    {
        // Ініціалізація змінних
        int x = 10;
        int y = 20;

        // Виводимо початкові значення
        Console.WriteLine($"До змiни: x = {x}, y = {y}");

        // Викликаємо функцію, передаючи параметри за посиланням
        ModifyValues(ref x, ref y);

        // Виводимо змінені значення
        Console.WriteLine($"Пiсля змiни: x = {x}, y = {y}");

        // Очікуємо натискання клавіші для завершення програми
        Console.WriteLine("\nНатиснiть будь-яку клавiшу для виходу...");
        Console.ReadKey();
    }
}
