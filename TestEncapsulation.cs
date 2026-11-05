using System;

class LibraryBook
{
    private int bookId;
    private string title;
    private string author;
    private bool isAvailable;
    private int borrowCount;
    public LibraryBook(int id, string name, string authorName)
    {
        bookId = id;
        title = name;
        author = authorName;
        isAvailable = true;
        borrowCount = 0;
    }
    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            borrowCount++;
            Console.WriteLine("\nBook Borrowed Successfully");
        }
        else
        {
            Console.WriteLine("\nBook is Already Borrowed!");
        }
    }
    public void ReturnBook()
    {
        if (!isAvailable)
        {
            isAvailable = true;
            Console.WriteLine("\nBook Returned Successfully");
        }
        else
        {
            Console.WriteLine("\nBook is Already Available!");
        }
    }
    public void DisplayBookDetails()
    {
        Console.WriteLine("\nBook: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Status: " +
            (isAvailable ? "Available" : "Not Available"));
    }
    public void CalculateBorrowCount()
    {
        Console.WriteLine("\nTotal Borrowings: " + borrowCount);
    }
}
class TestEncapsulation
{
   static void Main()
    {
        Console.Write("Enter Book Name: ");
        string name = Console.ReadLine();
        LibraryBook book = new LibraryBook(101, name, "John");
        book.DisplayBookDetails();
        book.BorrowBook();
        book.ReturnBook();
        book.DisplayBookDetails();
        book.CalculateBorrowCount();
    }
}