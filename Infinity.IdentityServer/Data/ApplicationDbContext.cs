using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;

namespace Infinity.IdentityServer.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        InfinityUser,
        InfinityRole,
        long,
        IdentityUserClaim<long>,
        InfinityUserRole,
        IdentityUserLogin<long>,
        IdentityRoleClaim<long>,
        IdentityUserToken<long>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<InfinityUser>(e =>
            {
                e.Property(p => p.Id).HasDefaultValue();//TODO generate Id here
                e.HasMany(p => p.Roles).WithOne(r => r.User).HasForeignKey(r => r.UserId).IsRequired();
            });
            builder.Entity<InfinityRole>(e => {
                e.Property(p => p.Id).HasDefaultValue();//TODO generate default value here
                e.HasMany(p => p.Users).WithOne(r => r.Role).HasForeignKey(f => f.RoleId).IsRequired();
                e.HasMany<IdentityRoleClaim<long>>().WithOne().HasForeignKey(p => p.RoleId).IsRequired();
            });
        }
    }
}
