using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Введення імені теки
        Console.Write("Введiть iм'я теки: ");
        string folderName = Console.ReadLine();

        // Перевірка, чи існує тека
        if (Directory.Exists(folderName))
        {
            // Отримання списку підкаталогів
            string[] subdirectories = Directory.GetDirectories(folderName);

            // Перевірка, чи є підкаталоги
            if (subdirectories.Length > 0)
            {
                Console.WriteLine($"Список пiдкаталогiв у тецi '{folderName}':");
                foreach (string subdirectory in subdirectories)
                {
                    Console.WriteLine(Path.GetFileName(subdirectory));
                }
            }
            else
            {
                Console.WriteLine($"У тецi '{folderName}' немає пiдкаталогiв.");
            }
        }
        else
        {
            Console.WriteLine($"Помилка: Тека '{folderName}' не iснує.");
        }
    }
}
