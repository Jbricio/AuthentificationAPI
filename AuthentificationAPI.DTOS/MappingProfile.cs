using AuthentificationAPI.Entities;
using AutoMapper;

namespace AuthentificationAPI.DTOS
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRequest, User>();
        }
    }
}
