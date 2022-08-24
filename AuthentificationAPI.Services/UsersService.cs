using AuthentificationAPI.Contracts;
using AuthentificationAPI.DTOS;
using AuthentificationAPI.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public async Task<bool> ValidateUser(UserRequest userRequest, CancellationToken cancellation)
        {
            var obtainedUsers = await _userRepo.GetById<User>((userSearch => userSearch.Name == userRequest.Name && userSearch.Password == userRequest.Password), cancellation);
            if (obtainedUsers is null)
                return false;

            return true;

        }
    }
}
