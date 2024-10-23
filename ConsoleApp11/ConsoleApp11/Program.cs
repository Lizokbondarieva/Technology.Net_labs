using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Введення речення користувачем
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            // Розбивка речення на слова за пробілом
            string[] words = sentence.Split(' ');

            // Виведення кожного слова на окремому рядку
            Console.WriteLine("Слова у реченні:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Затримка, щоб консоль не закрилася відразу
            Console.ReadLine();
        }
    }
}
