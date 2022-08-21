using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ForThirdBetweenSection
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string TopSentence { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string BottomSentence { get; set; }

    }
}
