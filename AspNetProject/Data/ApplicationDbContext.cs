using AspNetProject.Models;
using Microsoft.AspNetCore.Identity;
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

        builder.Entity<Book>()
            .HasOne(b => b.BookType)
            .WithMany(t => t.Books)
            .HasForeignKey("BookTypeId");

        builder.Entity<Book>()
            .HasOne(b => b.BookAuthor)
            .WithMany(a => a.Books)
            .HasForeignKey("BookAuthorId");

        builder.Entity<BorrowStatus>()
            .HasOne(s => s.Book)
            .WithMany(b => b.BorrowStatuses)
            .HasForeignKey("BookId");

        builder.Entity<BorrowStatus>()
            .HasOne(s => s.User)
            .WithMany(b => b.BorrowStatuses)
            .HasForeignKey("UserId");
        
        // TODO: Separate mocks
        builder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "Harry Potter: Philosopher's Stone",
                Quantity = 20,
                Description = "You are a wizard Harry.",
                BookAuthorId = 1,
                BookTypeId = 1
            },
            new Book
            {
                Id = 2,
                Title = "Harry Potter: Chamber of Secrets",
                Quantity = 100,
                Description = "You are a wizard Harry again.",
                BookAuthorId = 1,
                BookTypeId = 1
            },
            new Book
            {
                Id = 3,
                Title = "The Hunger Games",
                Quantity = 30,
                Description = "The Hunger Games description.",
                BookAuthorId = 2,
                BookTypeId = 2
            },
            new Book
            {
                Id = 4,
                Title = "Narnia",
                Quantity = 50,
                Description = "For Narnia!!!!!!!!!!!!",
                BookAuthorId = 3,
                BookTypeId = 1
            },
            new Book
            {
                Id = 5,
                Title = "Sherlock Holmes",
                Quantity = 15,
                Description = "Sherlock Holmes description.",
                BookAuthorId = 4,
                BookTypeId = 3
            }
        );

        builder.Entity<BookAuthor>().HasData(
            new BookAuthor
            {
                Id = 1,
                FirstName = "Joanne Murray",
                LastName = "Rowling"
            },
            new BookAuthor
            {
                Id = 2,
                FirstName = "Suzanne",
                LastName = "Collins"
            },
            new BookAuthor
            {
                Id = 3,
                FirstName = "Clive Staples",
                LastName = "Lewis"
            },
            new BookAuthor
            {
                Id = 4,
                FirstName = "Artur Conan",
                LastName = "Doyle"
            }
        );

        builder.Entity<BookType>().HasData(
            new BookType
            {
                Id = 1,
                Name = "Fantasy",
                Description =
                    "Fantasy is a genre of speculative fiction involving magical elements, typically set in a fictional universe and usually inspired by mythology or folklore. The term \"fantasy\" can also be used to describe a \"work of this genre\", usually literary."
            },
            new BookType
            {
                Id = 2,
                Name = "Action",
                Description =
                    "Action fiction is a literary genre that focuses on stories that involve high-stakes, high-energy, and fast-paced events. This genre includes a wide range of subgenres, such as spy novels, adventure stories, tales of terror and intrigue (\"cloak and dagger\") and mysteries. This kind of story utilizes suspense, the tension that is built up when the reader wishes to know how the conflict between the protagonist and antagonist is going to be resolved or what the solution to the puzzle of a thriller is."
            },
            new BookType
            {
                Id = 3,
                Name = "Crime",
                Description =
                    "Crime fiction, detective story, murder mystery, mystery novel, and police novel are terms used to describe narratives that centre on criminal acts and especially on the investigation, either by an amateur or a professional detective, of a crime, often a murder."
            }
        );

        const string adminId = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
        const string adminRoleId = "ad376a8f-9eab-4bb9-9fca-30b01540f445";

        const string userId = "a18be9c0-aa65-4af8-bd17-00bd9344e571";
        const string userRoleId = "ad376a8f-9eab-4bb9-9fca-30b01540f441";

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = adminRoleId,
                Name = "admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = userRoleId,
                Name = "user",
                NormalizedName = "USER"
            }
        );

        var hasher = new PasswordHasher<IdentityUser>();

        builder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = adminId,
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin123#"),
                SecurityStamp = string.Empty
            },
            new IdentityUser
            {
                Id = userId,
                UserName = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "User123#"),
                SecurityStamp = string.Empty
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminId,
            },
            new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = userId,
            }
        );

        builder.Entity<BorrowStatus>().HasData(
            new BorrowStatus
            {
                Id = 1,
                BookId = 1,
                UserId = userId,
                BorrowDate = DateTime.Now
            }
        );
    }
}