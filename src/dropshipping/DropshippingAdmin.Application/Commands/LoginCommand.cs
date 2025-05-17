// AuthService.Application/Commands/LoginCommand.cs - Scaffold do arquivo

using DropshippingAdmin.Application.Models;
using DropshippingAdmin.Domain;

namespace DropshippingAdmin.AuthService.Application.Commands
{
    // <summary>
    // Comando para realizar o login de um usu�rio.
    // </summary>
    public class LoginCommand
    {
        public LoginCommand() { }

        // <summary>
        // Fun��o para realizar o login de um usu�rio.
        // </summary>
        // <param name="loginCommandModel">Dados para fazer login do usu�rio.</param>
        // <returns>Retorna um objeto Login com as informa��es do usu�rio.</returns>
        public Login Execute(LoginRequest loginCommandModel)
        {
            // Aqui voc� pode adicionar a l�gica para autenticar o usu�rio, como verificar o banco de dados.
            // Por enquanto, vamos apenas retornar um objeto Login com os dados fornecidos.
            return new Login
            {
                Email = loginCommandModel.Email,
                Password = loginCommandModel.Password,
                Token = Guid.NewGuid().ToString(), // Simulando um token gerado
                IsAuthenticated = true,
                IsBlocked = false,
                IsExpired = false,
                IsTwoFactorEnabled = false
            };
        }
    }
}