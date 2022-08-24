using AuthentificationAPI.Contracts;
using AuthentificationAPI.Entities;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repositoryContext;
        private  IUserRepository _users;
        private  IJWTManagerRepository _jwtManagerRepository;
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
        public IJWTManagerRepository  JwtRepository
        {
            get
            {
                if (_jwtManagerRepository == null)
                {
                    _jwtManagerRepository = new JWTManagerRepository(_repositoryContext);
                }
                return _jwtManagerRepository;
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
