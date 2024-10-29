using System;

class Program
{
    // Делегат для вихідної функції
    public delegate double Function(double x);

    // Метод обчислення визначеного інтеграла методом прямокутників
    static double CalculateIntegral(Function func, double a, double b, int n)
    {
        double h = (b - a) / n; // Ширина прямокутника
        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            double x = a + i * h; // Ліва точка кожного прямокутника
            sum += func(x) * h;   // Додаємо площу кожного прямокутника
        }

        return sum;
    }

    // Визначення вихідної функції, наприклад, f(x) = x^2
    static double FunctionExample(double x)
    {
        return x * x;
    }

    static void Main()
    {
        // Введення меж інтегрування та кількості прямокутників
        Console.Write("Введiть нижню межу iнтегралу (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть верхню межу iнтегралу (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть кiлькiсть прямокутникiв (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Обчислення інтегралу
        double result = CalculateIntegral(FunctionExample, a, b, n);

        Console.WriteLine($"Визначений iнтеграл функцiї x^2 на вiдрiзку [{a}, {b}] дорiвнює: {result}");
    }
}
