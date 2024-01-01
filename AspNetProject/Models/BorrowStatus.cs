namespace AspNetProject.Models;

public class BorrowStatus
{
    public int Id { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public ApplicationUser User { get; set; }
    public Book Book { get; set; }
}