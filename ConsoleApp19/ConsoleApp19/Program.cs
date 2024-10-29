using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Вхідний список цілих чисел
        List<int> numbers = new List<int> { 101, 202, 345, 12321, 909, 500, 404, 111 };

        // Сортування за зменшенням останньої цифри
        var sortedList = numbers
            .OrderByDescending(n => n.ToString().Last())
            .ToList();

        // Виведення відсортованого списку
        Console.WriteLine("Список, вiдсортований за зменшенням останньої цифри:");
        sortedList.ForEach(Console.WriteLine);
    }
}
