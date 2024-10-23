
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();  // Використовуємо список для динамічного масиву
        int input;
        int sum = 0;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Введіть числа (завершіть введення нулем):");

        // Цикл для введення елементів масиву
        while (true)
        {
            string userInput = Console.ReadLine();  // Читаємо введені дані як рядок
            if (int.TryParse(userInput, out input))  // Перевіряємо, чи це ціле число
            {
                if (input == 0) break;  // Якщо введено 0, завершити цикл
                numbers.Add(input);  // Додаємо введене число до списку
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть ціле число.");  // Повідомлення про неправильний ввод
            }
        }

        // Обчислюємо суму елементів масиву
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Виведення суми елементів
        Console.WriteLine("Сума елементів: " + sum);
    }
}
