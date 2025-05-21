using DropshippingAdmin.Core.Application.Commands;
using FluentValidation;

namespace DropshippingAdmin.Core.Application.Validators
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
