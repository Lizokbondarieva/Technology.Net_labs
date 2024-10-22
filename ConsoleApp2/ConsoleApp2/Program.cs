using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Author(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Publisher
{
    public string Name { get; set; }
    public string City { get; set; }

    public Publisher(string name, string city)
    {
        Name = name;
        City = city;
    }
}

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public Publisher Publisher { get; set; }
    public int PublicationYear { get; set; }
    public double Price { get; set; }

    public Book(string title, Author author, Publisher publisher, int publicationYear, double price)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        PublicationYear = publicationYear;
        Price = price;
    }
}

public class Bookstore
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> SortBooksByTitle()
    {
        return books.OrderBy(b => b.Title).ToList();
    }

    public List<Book> SearchBooks(string searchTerm)
    {
        // Логіка пошуку
        return books.Where(b => b.Title.Contains(searchTerm)).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення авторів, видавців і книг
        Author author1 = new Author("Iван", "Франко");
        Publisher publisher1 = new Publisher("Веселка", "Львiв");

        Book book1 = new Book("Захар Беркут", author1, publisher1, 1883, 200.0);
        Book book2 = new Book("Каменярi", author1, publisher1, 1878, 150.0);

        // Створення книгарні
        Bookstore bookstore = new Bookstore();

        // Додавання книг до книгарні
        bookstore.AddBook(book1);
        bookstore.AddBook(book2);

        // Приклад пошуку книг за автором "Франко"
        var searchResults = bookstore.SearchBooks("Каменярi");
        foreach (var book in searchResults)
        {
            Console.WriteLine($"Книга: {book.Title}, Автор: {book.Author.LastName} {book.Author.FirstName}");
        }

        // Приклад сортування книг за назвою
        var sortedBooks = bookstore.SortBooksByTitle();
        foreach (var book in sortedBooks)
        {
            Console.WriteLine($"Книга: {book.Title}");
        }
    }
}
