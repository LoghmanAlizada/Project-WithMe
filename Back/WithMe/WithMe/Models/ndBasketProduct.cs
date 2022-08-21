using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WithMe.Models
{
    public class ndBasketProduct
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
