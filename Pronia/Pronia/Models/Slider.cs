using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pronia.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(maximumLength: 25)]
        public string Title1 { get; set; }
        [StringLength(maximumLength: 50)]
        public string Title2 { get; set; }
        [StringLength(maximumLength: 350)]
        public string Desc { get; set; }
        public string RedirectUrl { get; set; }
        public string ButtonText { get; set; }
        [StringLength(maximumLength: 100)]
        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
