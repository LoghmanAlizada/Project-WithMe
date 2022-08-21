using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class OurStory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string SpanText { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Text { get; set; }
        public string ImageURL { get; set; }
    }
}
