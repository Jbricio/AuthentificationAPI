using AuthentificationAPI.Entities;
using AuthentificationAPI.Persistence.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace AuthentificationAPI.Persistence
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfig());
        }
        public DbSet<User> User { get; set; }
        
    }
}