using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithMe.Models
{
    public class DessertsSectionForThirdMenu
    {
        public int Id { get; set; }
        public string SectionTitle { get; set; }
        public string ImageURL { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
