using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Identity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : ControllerBase
    {
        [HttpPost("register-cpf")]
        public IActionResult RegisterCpf([FromBody] RegisterCpfRequest request)
        {
            // Validação simples de CPF
            if (string.IsNullOrWhiteSpace(request.Cpf) || request.Cpf.Length != 11 || !request.Cpf.All(char.IsDigit))
                return BadRequest("CPF inválido");
            // Aqui você pode adicionar lógica de persistência em banco de dados
            return Ok(new { registered = true, type = "Pessoa Física", cpf = request.Cpf, nome = request.Nome });
        }

        [HttpPost("register-cnpj")]
        public IActionResult RegisterCnpj([FromBody] RegisterCnpjRequest request)
        {
            // Validação simples de CNPJ
            if (string.IsNullOrWhiteSpace(request.Cnpj) || request.Cnpj.Length != 14 || !request.Cnpj.All(char.IsDigit))
                return BadRequest("CNPJ inválido");
            // Aqui você pode adicionar lógica de persistência em banco de dados
            return Ok(new { registered = true, type = "Pessoa Jurídica", cnpj = request.Cnpj, razaoSocial = request.RazaoSocial });
        }
    }

    public class RegisterCpfRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; }
    }
    public class RegisterCnpjRequest
    {
        public string RazaoSocial { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        public DateTime? DataAbertura { get; set; }
    }
}