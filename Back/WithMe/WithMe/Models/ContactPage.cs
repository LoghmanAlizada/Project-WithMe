using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ContactPage
    {
        public int Id { get; set; }
        public string SectionTitle { get; set; }
        public string CartTitle { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Location { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Mail { get; set; }
        public string TitleForHour { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string WeekTime { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string WeekendTime { get; set; }
    }
}
