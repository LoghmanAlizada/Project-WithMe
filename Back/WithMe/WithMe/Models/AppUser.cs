using Microsoft.AspNetCore.Identity;
using System.Data.Common;

namespace WithMe.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }

    }
}
