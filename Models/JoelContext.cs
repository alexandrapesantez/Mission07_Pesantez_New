// Include necessary using directives

// Define the namespace for the models
using Microsoft.EntityFrameworkCore;

namespace Mission06_Pesantez.Models
{
    // Define a class called JoelContext which inherits from DbContext
    public class JoelContext : DbContext
    {
        // Constructor for the JoelContext class which accepts DbContextOptions
        public JoelContext(DbContextOptions<JoelContext> options) : base(options)
        {
            // Empty constructor body as it just calls the base constructor
        }

        // DbSet property to represent a collection of Application entities
        public DbSet<Application> Applications { get; set; }
    }
}

