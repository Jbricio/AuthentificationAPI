using AuthentificationAPI.Contracts;
using AuthentificationAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
    public class UserRepository : RepositoryBase<int>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
