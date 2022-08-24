using AuthentificationAPI.DTOS;
using AuthentificationAPI.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Contracts
{
    public interface IJWTManager
    {
        Task<Tokens> Authenticate(UserRequest users, CancellationToken cancellationToken);
    }
}
