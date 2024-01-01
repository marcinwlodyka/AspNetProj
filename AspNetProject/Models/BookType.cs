namespace AspNetProject.Models;

public class BookType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Book Book { get; set; }
}