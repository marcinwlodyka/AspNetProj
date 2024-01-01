using AspNetProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetProject.Data;


public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);
    }
}

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<BorrowStatus> BorrowStatuses { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {   
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        new ApplicationUserEntityConfiguration().Configure(builder.Entity<ApplicationUser>());
    }
}