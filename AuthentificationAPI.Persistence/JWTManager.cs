using AuthentificationAPI.Contracts;
using AuthentificationAPI.DTOS;
using AuthentificationAPI.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
    public class JWTManager : IJWTManager
    {
        private readonly IUsersService _usersService;
        private readonly IConfiguration _configuration;

        public JWTManager(IUsersService usersService, IConfiguration configuration)
        {
            _usersService = usersService;
            _configuration = configuration;
        }

        public async Task<Tokens> Authenticate(UserRequest users, CancellationToken cancellationToken)
        {
            var validation = await _usersService.ValidateUser(users, cancellationToken);
            if (validation)
            {
                // Else we generate JSON Web Token
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                  {
             new Claim(ClaimTypes.Name, users.Name),
			 //new Claim(ClaimTypes.Role, "Admin"),
			 //new Claim(ClaimTypes.Role, "Guest"),
				  }),
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    Issuer = _configuration["JWT:Issuer"],
                    Audience = _configuration["JWT:Audience"],
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return new Tokens { Token = tokenHandler.WriteToken(token) };
            }
            return null;
        }
    }
}
