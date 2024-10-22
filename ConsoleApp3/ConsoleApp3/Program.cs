using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Point3D
{
    // Властивості для координат точки
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Конструктор для ініціалізації координат
    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Метод для виведення координат точки
    public void PrintCoordinates()
    {
        Console.WriteLine($"Точка має координати: X = {X}, Y = {Y}, Z = {Z}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта точки
        Point3D point = new Point3D(1.0, 2.0, 3.0);

        // Виведення координат точки
        point.PrintCoordinates();
    }
}
