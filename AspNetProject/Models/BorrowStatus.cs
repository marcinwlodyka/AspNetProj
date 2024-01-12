using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetProject.Models;

public class BorrowStatus
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    
    public ApplicationUser User { get; set; }
    public string UserId { get; set; }
    
    public Book Book { get; set; }
    public int BookId { get; set; }
}