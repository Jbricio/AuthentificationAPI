using AuthentificationAPI.Contracts;
using AuthentificationAPI.Entities;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repositoryContext;

        
        public async Task Save()
        {
            await _repositoryContext.SaveChangesAsync();
        }

        public RepositoryWrapper(RepositoryContext repositoryContex)
        {
            _repositoryContext = repositoryContex;
        }
    }
}
