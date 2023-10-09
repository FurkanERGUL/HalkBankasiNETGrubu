using Microsoft.AspNetCore.Identity;

namespace _52_WEB_Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
