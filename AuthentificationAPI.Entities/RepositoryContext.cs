using Microsoft.EntityFrameworkCore;

namespace AuthentificationAPI.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

    }
}