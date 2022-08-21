using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ForSecondBetweenSection
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string WeekDaysTime { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string WeekEndTime { get; set; }
    }
}
