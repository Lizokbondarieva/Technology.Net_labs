using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Вхідний список цілих чисел
        List<int> numbers = new List<int> { 101, 202, 345, 12321, 909, 500, 404, 111 };

        // Пошук чисел, що починаються і закінчуються на однакову цифру
        var result = numbers.Where(num => num.ToString().First() == num.ToString().Last());

        Console.WriteLine("Числа, що починаються та закiнчуються однаковою цифрою:");
        foreach (var n in result)
            Console.WriteLine(n);
        Console.ReadKey();
    }
}
