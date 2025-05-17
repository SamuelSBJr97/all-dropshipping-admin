// AuthService.Application/Commands/RegisterCommand.cs - Scaffold do arquivo

using DropshippingAdmin.Application.Models;
using InfrastructureService.Domain;

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
                    Email = registerCommandModel.Email,
                    Password = registerCommandModel.Password,
                    Token = Guid.NewGuid().ToString(), // Simulando um token gerado
                    IsAuthenticated = true,
                    IsBlocked = false,
                    IsExpired = false,
                    IsTwoFactorEnabled = false
                };
        }
    }
}