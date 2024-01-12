using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetProject.Models;

public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    
    public BookAuthor BookAuthor { get; set; }
    public int BookAuthorId { get; set; }
    
    public BookType BookType { get; set; }
    public int BookTypeId { get; set; }
    
    public IEnumerable<BorrowStatus> BorrowStatuses { get; set; }
}