using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithMe.Models
{
    public class ForPartner
    {
        public int Id { get; set; }
        public string SpanText { get; set; }
        public string Title { get; set; }
        [Required]
        public string FirstPartnerImageURl { get; set; }
        [Required]
        [NotMapped]
        public IFormFile FirstPhoto { get; set; }
        [Required]
        public string SecondPartnerImageURL { get; set; }
        [Required]
        [NotMapped]
        public IFormFile SecondPhoto { get; set; }
        [Required]
        public string ThirdPartnerImageURL { get; set; }
        [Required]
        [NotMapped]
        public IFormFile ThirdPhoto { get; set; }
        [Required]
        public string FourthPartnerImageURL { get; set; }
        [Required]
        [NotMapped]
        public IFormFile FourthPhoto { get; set; }

    }
}
