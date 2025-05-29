using AutoMapper;
using DropshippingAdmin.Core.Application.Dtos;
using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<AdminUser, AdminUserDto>().ReverseMap();
        }
    }
}
