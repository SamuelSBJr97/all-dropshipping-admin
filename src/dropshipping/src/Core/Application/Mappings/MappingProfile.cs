using AutoMapper;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Application.Dtos;

namespace DropshippingAdmin.Core.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
