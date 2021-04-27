using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Infinity.IdentityServer.Data
{
    public class InfinityRole : IdentityRole<Guid>
    {
        public ICollection<InfinityUserRole> Users { get; } = new List<InfinityUserRole>();
        public InfinityRole() { }
        public InfinityRole(string roleName) : base(roleName) { }
    }
}
