using Microsoft.AspNetCore.Identity;
using System;

namespace Infinity.IdentityServer.Models
{
    public class InfinityUserRole : IdentityUserRole<long>
    {
        public InfinityUser User { get; set; }
        public InfinityRole Role { get; set; }
    }
}
