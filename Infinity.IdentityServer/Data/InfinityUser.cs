using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Infinity.IdentityServer.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class InfinityUser : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<InfinityUserRole> Roles { get; set; }
    }
}
