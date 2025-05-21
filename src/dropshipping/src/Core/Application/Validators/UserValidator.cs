using DropshippingAdmin.Core.Application.Dtos;
using FluentValidation;

namespace DropshippingAdmin.Core.Application.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}
