using DropshippingAdmin.Infrastructure;
using DropshippingAdmin.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Adicione o contexto do banco de dados
builder.Services.AddDbContext<DropshippingAdminContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DropshippingAdminDatabase")));

// Configurar autenticação JWT
var jwtSecret = builder.Configuration.GetValue<string>("JwtSecret");
if (string.IsNullOrEmpty(jwtSecret))
{
    throw new InvalidOperationException("JwtSecret is not configured properly.");
}
var key = Encoding.ASCII.GetBytes(jwtSecret);
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

// Add services to the container.
builder.Services.AddControllers();

// Registre o serviço
builder.Services.AddScoped<IAuthUserService, AuthUserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
