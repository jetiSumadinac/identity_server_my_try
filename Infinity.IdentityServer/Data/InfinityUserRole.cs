using Microsoft.AspNetCore.Identity;
using System;

namespace Infinity.IdentityServer.Data
{
    public class InfinityUserRole : IdentityUserRole<long>
    {
        public InfinityUser User { get; set; }
        public InfinityRole Role { get; set; }
    }
}
