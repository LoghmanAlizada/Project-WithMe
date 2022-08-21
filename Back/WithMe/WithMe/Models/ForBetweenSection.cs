using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ForBetweenSection
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public int Count { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string SpanText { get; set; }

    }
}
