using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Введення імені теки та розширення файлів
        Console.Write("Введiть iм'я теки: ");
        string folderName = Console.ReadLine();

        Console.Write("Введiть розширення файлiв (наприклад, .txt): ");
        string fileExtension = Console.ReadLine();

        // Перевірка, чи існує тека
        if (Directory.Exists(folderName))
        {
            // Отримання файлів з вказаним розширенням
            string[] files = Directory.GetFiles(folderName, $"*{fileExtension}");

            // Перевірка, чи знайдено файли з вказаним розширенням
            if (files.Length > 0)
            {
                Console.WriteLine($"Список файлiв з розширенням '{fileExtension}' у теці '{folderName}':");
                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
            else
            {
                Console.WriteLine($"Файлiв з розширенням '{fileExtension}' у тецi '{folderName}' не знайдено.");
            }
        }
        else
        {
            Console.WriteLine($"Помилка: Тека '{folderName}' не iснує.");
        }
    }
}
