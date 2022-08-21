using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class PageIntro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
