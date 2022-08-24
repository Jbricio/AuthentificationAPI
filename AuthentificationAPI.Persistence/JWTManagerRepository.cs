using AuthentificationAPI.Contracts;
using AuthentificationAPI.DTOS;
using AuthentificationAPI.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
	public class JWTManagerRepository : RepositoryBase<JWTManagerRepository>, IJWTManagerRepository
	{

		public JWTManagerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

         public Tokens Authenticate(UserRequest users)
        {
            throw new NotImplementedException();
        }
    
        
	}
}
