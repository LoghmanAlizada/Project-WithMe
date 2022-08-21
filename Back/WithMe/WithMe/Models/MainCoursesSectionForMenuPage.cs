using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class MainCoursesSectionForMenuPage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public int Price { get; set; }
        [Required(ErrorMessage = "cannot be kept empty")]
        public string Description { get; set; }

    }
}
