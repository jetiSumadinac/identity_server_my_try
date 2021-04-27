using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinity.IdentityServer.Models
{
    public class InfinityRole : IdentityRole<long>
    {
        public ICollection<InfinityUserRole> Users { get; } = new List<InfinityUserRole>();
        public InfinityRole() { }
        public InfinityRole(string roleName) : base(roleName) { }
    }
}
