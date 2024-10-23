using System;

class Program
{
    static void Main()
    {
        // Ініціалізація двовимірного масиву дійсних чисел
        double[,] matrix = {
            { 0.0, -2.3, 5.1 },
            { 4.4, 0.0, -1.0 },
            { -3.5, 6.7, 0.0 }
        };

        Console.WriteLine("Початковий масив:");
        PrintMatrix(matrix);

        // Замінюємо нулі на одиниці, а від'ємні значення на нулі
        for (int i = 0; i < matrix.GetLength(0); i++)  // Проходимо по рядках
        {
            for (int j = 0; j < matrix.GetLength(1); j++)  // Проходимо по стовпцях
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, j] = 1;  // Замінюємо нулі на одиниці
                }
                else if (matrix[i, j] < 0)
                {
                    matrix[i, j] = 0;  // Замінюємо від'ємні значення на нулі
                }
            }
        }
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("\nМодифікований масив:");
        PrintMatrix(matrix);
    }

    // Метод для виведення двовимірного масиву на консоль
    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
