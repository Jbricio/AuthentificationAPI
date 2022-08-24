using AuthentificationAPI.DTOS;
using AuthentificationAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthentificationAPI.Contracts
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(UserRequest users);
    }
}
