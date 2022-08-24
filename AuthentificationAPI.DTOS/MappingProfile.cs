using AutoMapper;
using AuthentificationAPI.Entities;

namespace AuthentificationAPI.DTOS
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRequest, Users>();
        }
    }
}
