using AuthentificationAPI.Contracts;
using AuthentificationAPI.Entities;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repositoryContext;
        private  IUserRepository _users;
        public IUserRepository User
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_repositoryContext);
                }
                return _users;
            }
        }

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
