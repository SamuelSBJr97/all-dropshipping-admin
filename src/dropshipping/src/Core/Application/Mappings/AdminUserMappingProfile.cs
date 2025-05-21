using AutoMapper;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Application.Dtos;

namespace DropshippingAdmin.Core.Application.Mappings
{
    public class AdminUserMappingProfile : Profile
    {
        public AdminUserMappingProfile()
        {
            CreateMap<AdminUser, AdminUserDto>();
        }
    }
}
