using AuthentificationAPI.DTOS;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Contracts
{
    public interface IUsersService
    {
        Task<bool> ValidateUser(UserRequest user, CancellationToken cancellation);

    }
}
