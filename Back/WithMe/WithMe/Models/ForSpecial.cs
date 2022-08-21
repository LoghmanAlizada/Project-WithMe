using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ForSpecial
    {
        public int Id { get; set; }
        public string SpanText { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string IconURL { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string CardTitle { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string CardDescription { get; set; }

    }
}
