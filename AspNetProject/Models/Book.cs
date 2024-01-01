namespace AspNetProject.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public BookAuthor BookAuthor { get; set; }
    public BookType BookType { get; set; }
    public BorrowStatus BorrowStatus { get; set; }
}