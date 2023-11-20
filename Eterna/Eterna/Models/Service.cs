using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:30)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Description { get; set; }
        [Required]
        public string Logo { get; set; }
    }
}
