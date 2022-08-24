using AuthentificationAPI.Contracts;
using AuthentificationAPI.DTOS;
using AuthentificationAPI.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UsersService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepo = userRepository;
            _mapper = mapper;
        }
        public bool ValidateUser(UserRequest user, CancellationToken cancellation)
        {
            //var obtainedUser = await _repository.User.GetUser(user => user.Name == Name &&
            //user => user.Password == Password);
            /*var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, users.Name)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token) };*/
            var user1=_userRepo.GetById<Users>(x => x.Id == 0,cancellation);
    
            var entity = _userRepo.GetEntity<Users>(cancellation);
            return false;
            
        }
    }
}
