using System;

class Program
{
    static void Main()
    {
        // Ініціалізація двовимірного масиву дійсних чисел
        double[,] matrix = {
            { 0.0, 2.2, 4.4 },
            { 4.2, 0.0, 4.1 },
            { 2.1, 6.3, 0.0 }
        };

        Console.WriteLine("Початковий масив:");
        PrintMatrix(matrix);

        // Обчислення середнього арифметичного всіх елементів
        double sum = 0;
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
                count++;
            }
        }

        double average = sum / count;  // Обчислюємо середнє арифметичне

        // Замінюємо нулі середнім арифметичним
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, j] = average;
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
