// Include necessary using directives

// Define the namespace for the models
using Microsoft.EntityFrameworkCore;

namespace Mission06_Pesantez.Models
{
    // Define a class called JoelContext which inherits from DbContext
    public class JoelContext : DbContext //Liaison from the app to the database
    {
        // Constructor for the JoelContext class which accepts DbContextOptions
        public JoelContext(DbContextOptions<JoelContext> options) : base(options)
        {
            // Empty constructor body as it just calls the base constructor
        }

        // DbSet property to represent a collection of Application entities
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                new Category { CategoryID = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 2, CategoryName = "Drama" },
                new Category { CategoryID = 3, CategoryName = "Television" },
                new Category { CategoryID = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 5, CategoryName = "Family" },
                new Category { CategoryID = 6, CategoryName = "Comedy" },
                new Category { CategoryID = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
                );
        }
    }
}

