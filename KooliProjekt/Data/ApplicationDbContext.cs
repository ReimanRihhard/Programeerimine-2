using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Folder> Folders { get; set; }

        public DbSet<Cloud> Clouds { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Photos> Photos { get; set; }

    }

    public class User
    {
    }
}