using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Введення імені теки та файлу
        Console.Write("Введiть iм'я теки: ");
        string folderName = Console.ReadLine();

        Console.Write("Введiть iм'я файлу (з розширенням): ");
        string fileName = Console.ReadLine();

        // Створення нової теки
        Directory.CreateDirectory(folderName);
        Console.WriteLine($"Теку '{folderName}' створено.");

        // Створення нового файлу в новій теці
        string filePath = Path.Combine(folderName, fileName);
        using (File.Create(filePath))
        {
            Console.WriteLine($"Файл '{fileName}' створено в тецi '{folderName}'.");
        }

        // Виведення імен усіх файлів в теці
        Console.WriteLine("Список файлiв у тецi:");
        foreach (string file in Directory.GetFiles(folderName))
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        // Видалення файлу
        File.Delete(filePath);
        Console.WriteLine($"Файл '{fileName}' видалено.");

        // Видалення теки
        Directory.Delete(folderName);
        Console.WriteLine($"Теку '{folderName}' видалено.");
    }
}
