using Microsoft.AspNetCore.Identity;

namespace _53_WEB_IdentityRole.Models.VMs
{
    public class UserRoleVM
    {
        public string User { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public string Name { get; set; }
    }
}
