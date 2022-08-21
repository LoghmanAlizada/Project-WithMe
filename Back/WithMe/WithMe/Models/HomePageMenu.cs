using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithMe.Models
{
    public class HomePageMenu
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ButtonText { get; set; }
    }
}
