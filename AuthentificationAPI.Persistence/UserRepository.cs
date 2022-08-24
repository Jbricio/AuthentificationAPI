using AuthentificationAPI.Contracts;

namespace AuthentificationAPI.Persistence
{
    public class UserRepository : RepositoryBase<int>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
