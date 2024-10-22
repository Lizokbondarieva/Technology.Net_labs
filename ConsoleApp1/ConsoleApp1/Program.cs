using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Group { get; set; }
    public List<Grade> Grades { get; set; }

    public Student(string firstName, string lastName, int group)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        Grades = new List<Grade>();
    }

    public double AverageGrade
    {
        get
        {
            return Grades.Any() ? Grades.Average(g => g.Score) : 0;
        }
    }
}

public class Grade
{
    public string Subject { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }

    public Grade(string subject, int score, DateTime date)
    {
        Subject = subject;
        Score = score;
        Date = date;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("Введiть iм'я студента (або 'exit' для виходу):");
            string firstName = Console.ReadLine();
            if (firstName.ToLower() == "exit") break;

            Console.Write("Введiть прiзвище: ");
            string lastName = Console.ReadLine();
            Console.Write("Введiть групу: ");
            int group = int.Parse(Console.ReadLine());

            Student student = new Student(firstName, lastName, group);

            while (true)
            {
                Console.WriteLine("Введiть назву предмету (або 'exit' для наступного студента):");
                string subject = Console.ReadLine();
                if (subject.ToLower() == "exit") break;

                Console.Write("Введiть оцiнку: ");
                int score = int.Parse(Console.ReadLine());
                Console.Write("Введiть дату (рррр-мм-дд): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                student.Grades.Add(new Grade(subject, score, date));
            }

            students.Add(student);
        }

        // Виведення результатів
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.FirstName} {student.LastName}, група {student.Group}");
            Console.WriteLine("Оцiнки:");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"  {grade.Subject}: {grade.Score} ({grade.Date:d})");
            }
            Console.WriteLine($"Середнiй бал: {student.AverageGrade:F2}");
            Console.WriteLine();
            
        }
    }
}