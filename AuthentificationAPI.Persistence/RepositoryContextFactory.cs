using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace AuthentificationAPI.Persistence
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        private readonly string _connString = "Data Source=.,1433;Initial Catalog=TokenDB;User ID=sa;Password=Passw0rd;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public RepositoryContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<RepositoryContext>();
            optionBuilder.UseSqlServer(_connString);
            return new RepositoryContext(optionBuilder.Options);
        }
    }
}
