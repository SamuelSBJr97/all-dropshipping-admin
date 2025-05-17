// AuthService.Application/Commands/RegisterCommand.cs - Scaffold do arquivo

using DropshippingAdmin.Application.Models;
using DropshippingAdmin.Domain;

namespace DropshippingAdmin.AuthService.Application.Commands
{
    // <summary>
    // Comando para registrar um novo usu�rio.
    // </summary>
    public class RegisterCommand
    {
        public RegisterCommand() { }

           // <summary>
            // Fun��o para registrar um novo usu�rio.
            // </summary>
            // <param name="registerCommandModel">Dados para registrar o usu�rio.</param>
            // <returns>Retorna um objeto Login com as informa��es do usu�rio.</returns>
            public User Execute(RegisterRequest registerCommandModel)
            {
                // Aqui voc� pode adicionar a l�gica para registrar o usu�rio, como salvar no banco de dados.
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