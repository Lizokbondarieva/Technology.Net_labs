using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Вхідний список цілих чисел
        List<int> numbers = new List<int> { 101, 202, 345, 12321, 909, 500, 404, 111 };

        // Пошук чисел, що починаються і закінчуються на однакову цифру за допомогою LINQ
        var result = numbers
            .Where(n => n.ToString().First() == n.ToString().Last())
            .ToList();

        // Виведення результату
        Console.WriteLine("Числа, що починаються i закiнчуються однаковою цифрою:");
        result.ForEach(Console.WriteLine);
    }
}
