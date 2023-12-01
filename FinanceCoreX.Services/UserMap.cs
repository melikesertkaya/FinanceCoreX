using AutoMapper;
using FinanceCoreX.Core.Entities;
using FinanceCoreX.Services.Dtos;

namespace FinanceCoreX.Services
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
