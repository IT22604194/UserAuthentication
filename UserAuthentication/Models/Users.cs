using Microsoft.AspNetCore.Identity;

namespace UserAuthentication.Models
{
    public class Users : IdentityUser

    {
        public String FullName  {get; set;}
    }
}
