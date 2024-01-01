namespace AspNetProject.Models;

public class BookAuthor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Book Book { get; set; }
}