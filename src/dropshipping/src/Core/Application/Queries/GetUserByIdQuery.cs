using DropshippingAdmin.Core.Application.Dtos;

namespace DropshippingAdmin.Core.Application.Queries
{
    public class GetUserByIdQuery : IQuery<UserDto>
    {
        public Guid Id { get; set; }
        public GetUserByIdQuery(Guid id) => Id = id;
    }
}
