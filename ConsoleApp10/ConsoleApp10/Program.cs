using System;

namespace ParallelepipedApp
{
    class Parallelepiped
    {
        // Приватні поля для зберігання розмірів паралелепіпеда
        private double length;
        private double width;
        private double height;

        // Властивості для доступу до довжини, ширини та висоти
        public double Length
        {
            get { return length; }
            set { length = value > 0 ? value : throw new ArgumentException("Довжина повинна бути бiльше 0"); }
        }

        public double Width
        {
            get { return width; }
            set { width = value > 0 ? value : throw new ArgumentException("Ширина повинна бути бiльше 0"); }
        }

        public double Height
        {
            get { return height; }
            set { height = value > 0 ? value : throw new ArgumentException("Висота повинна бути бiльше 0"); }
        }

        // Конструктор класу
        public Parallelepiped(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        // Індексатор для доступу до довжини, ширини та висоти через індекси
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Length;
                    case 1:
                        return Width;
                    case 2:
                        return Height;
                    default:
                        throw new IndexOutOfRangeException("Невiрний iндекс! Використовуйте 0 для довжини, 1 для ширини або 2 для висоти.");
                }

            }
            set
            {
                switch (index)
                {
                    case 0:
                        Length = value;
                        break;
                    case 1:
                        Width = value;
                        break;
                    case 2:
                        Height = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Невiрний іiдекс! Використовуйте 0 для довжини, 1 для ширини або 2 для висоти.");
                }
            }
        }

        // Метод для розрахунку об'єму
        public double CalculateVolume()
        {
            return Length * Width * Height;
        }

        // Метод для виведення інформації про паралелепіпед
        public void DisplayInfo()
        {
            Console.WriteLine($"Паралелепiпед: Довжина = {Length}, Ширина = {Width}, Висота = {Height}");
            Console.WriteLine($"Об'єм = {CalculateVolume()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкту паралелепіпеда
            Parallelepiped parallelepiped = new Parallelepiped(3, 4, 5);

            // Використання властивостей
            Console.WriteLine("Доступ через властивостi:");
            parallelepiped.DisplayInfo();

            // Використання індексатора
            Console.WriteLine("\nДоступ через iндексатор:");
            Console.WriteLine($"Довжина (iндекс 0): {parallelepiped[0]}");
            Console.WriteLine($"Ширина (iндекс 1): {parallelepiped[1]}");
            Console.WriteLine($"Висота (iндекс 2): {parallelepiped[2]}");

            // Зміна значень через індексатор
            parallelepiped[0] = 6; // Змінюємо довжину
            parallelepiped[1] = 7; // Змінюємо ширину
            parallelepiped[2] = 8; // Змінюємо висоту

            Console.WriteLine("\nПiсля змiни через iндексатор:");
            parallelepiped.DisplayInfo();

            Console.ReadLine();
        }
    }
}
