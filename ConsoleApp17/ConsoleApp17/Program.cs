using System;

class Program
{
    // Делегат для вихідної функції
    public delegate double Function(double x);

    // Метод обчислення визначеного інтеграла методом трапецій
    static double CalculateIntegral(Function func, double a, double b, int n)
    {
        double h = (b - a) / n; // Ширина трапецій
        double sum = 0.5 * (func(a) + func(b)); // Площа крайніх трапецій

        for (int i = 1; i < n; i++)
        {
            double x = a + i * h;
            sum += func(x); // Сума висот середніх точок
        }

        return sum * h; // Множимо на ширину
    }

    // Вихідна функція, наприклад, f(x) = x^2
    static double FunctionExample(double x)
    {
        return x * x;
    }

    static void Main()
    {
        // Введення меж інтегрування та кількості трапецій
        Console.Write("Введiть нижню межу iнтегралу (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть верхню межу iнтегралу (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть кiлькiсть трапецiй (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Обчислення інтегралу
        double result = CalculateIntegral(FunctionExample, a, b, n);

        Console.WriteLine($"Визначений iнтеграл функцiї x^2 на вiдрiзку [{a}, {b}] дорiвнює: {result}");
    }
}
