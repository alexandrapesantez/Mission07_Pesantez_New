// Include necessary using directives
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Define the namespace for the models
namespace Mission06_Pesantez.Models
{
    // Define a class called Application
    public class Application
    {
        // Define a property for the primary key of the Application entity
        [Key] // Specifies that this property is the primary key
        [Required] // Specifies that this property is required
        public int ApplicationID { get; set; }

        // Define additional properties for the Application entity
        [ForeignKey("CategoryID")]
        public string CategoryID { get; set; } // Represents the category of the application
        public Category Category { get; set; }
        public string Title { get; set; } // Represents the title of the application
        public int Year { get; set; } // Represents the year of the application

        public string Director { get; set; } // Represents the director of the application
        public string Rating { get; set; } // Represents the rating of the application
        public bool Edited { get; set; } // Represents whether the application is edited or not (nullable boolean)
        public bool CopiedToPlex { get; set; }
        public string? LentTo { get; set; } // Represents the person to whom the application is lent (nullable)
        public string? Notes { get; set; } // Represents any additional notes about the application (nullable)
    }
}

