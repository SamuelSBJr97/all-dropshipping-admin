// AuthService.Application/Commands/RegisterCommand.cs - Scaffold do arquivo

using DropshippingAdmin.Application.Models;
using DropshippingAdmin.Domain;

namespace DropshippingAdmin.AuthService.Application.Commands
{
    // <summary>
    // Comando para registrar um novo usuário.
    // </summary>
    public class RegisterCommand
    {
        public RegisterCommand() { }

           // <summary>
            // Função para registrar um novo usuário.
            // </summary>
            // <param name="registerCommandModel">Dados para registrar o usuário.</param>
            // <returns>Retorna um objeto Login com as informações do usuário.</returns>
            public User Execute(RegisterRequest registerCommandModel)
            {
                // Aqui você pode adicionar a lógica para registrar o usuário, como salvar no banco de dados.
                // Por enquanto, vamos apenas retornar um objeto Login com os dados fornecidos.
                return new User
                {
                    Name = registerCommandModel.Name,
                    Email = registerCommandModel.Email,
                    PasswordHash = registerCommandModel.PasswordHash,
                    TwoFactorEnabled = registerCommandModel.TwoFactorEnabled,
                    CreatedAt = DateTime.UtcNow,
                    Token = Guid.NewGuid().ToString()
                };
        }
    }
}