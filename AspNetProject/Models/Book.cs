using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AspNetProject.Models;

public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    
    [ValidateNever]
    [DisplayName("Author")]
    public BookAuthor BookAuthor { get; set; }
    public int BookAuthorId { get; set; }
    
    [ValidateNever]
    [DisplayName("Type")]
    public BookType BookType { get; set; }
    public int BookTypeId { get; set; }
    
    [ValidateNever]
    public IEnumerable<BorrowStatus> BorrowStatuses { get; set; }
}