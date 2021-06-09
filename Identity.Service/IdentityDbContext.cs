using Mchyll.Identity.Framework;
using Microsoft.EntityFrameworkCore;

namespace Mchyll.Identity.Service
{
    public class IdentityDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
        }
    }
}
