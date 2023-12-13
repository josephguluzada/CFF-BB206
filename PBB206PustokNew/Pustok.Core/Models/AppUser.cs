using Microsoft.AspNetCore.Identity;

namespace Pustok.Core.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string BirthDate { get; set; }

        public List<BasketItem> BasketItems { get; set; }
        public List<Order> Orders { get; set; }
    }
}
