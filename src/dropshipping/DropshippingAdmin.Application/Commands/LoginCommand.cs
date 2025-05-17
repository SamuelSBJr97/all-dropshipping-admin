// AuthService.Application/Commands/LoginCommand.cs - Scaffold do arquivo

using DropshippingAdmin.Application.Models;
using DropshippingAdmin.Domain;

namespace DropshippingAdmin.AuthService.Application.Commands
{
    // <summary>
    // Comando para realizar o login de um usuário.
    // </summary>
    public class LoginCommand
    {
        public LoginCommand() { }

        // <summary>
        // Função para realizar o login de um usuário.
        // </summary>
        // <param name="loginCommandModel">Dados para fazer login do usuário.</param>
        // <returns>Retorna um objeto Login com as informações do usuário.</returns>
        public Login Execute(LoginRequest loginCommandModel)
        {
            // Aqui você pode adicionar a lógica para autenticar o usuário, como verificar o banco de dados.
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