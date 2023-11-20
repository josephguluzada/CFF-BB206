using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:60)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength:250)]
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
        public string RedirectUrl { get; set; }
    }
}
