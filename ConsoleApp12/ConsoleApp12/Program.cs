using System;


namespace JoinWords
{
    class Program
    {
        static void Main()
        {
            // Запитуємо у користувача введення речення
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть речення:");
            string input = Console.ReadLine();

            // Розділяємо речення на слова
            string[] words = input.Split(' ');

            // Зшиваємо всі слова без пробілів
            string result = string.Join("", words);

            // Виводимо результат
            Console.WriteLine("Зшиті слова: " + result);
        }
    }
}