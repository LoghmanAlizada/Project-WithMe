using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ChefPage
    {
        public int Id { get; set; }
        public string SectionTitle { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
    }
}
