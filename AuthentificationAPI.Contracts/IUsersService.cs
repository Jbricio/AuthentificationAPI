using AuthentificationAPI.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Contracts
{
    public interface IUsersService
    {
        Task<bool> ValidateUser(UserRequest user,CancellationToken cancellation);

    }
}
