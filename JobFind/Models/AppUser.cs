using Microsoft.AspNetCore.Identity;

namespace JobFind.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
