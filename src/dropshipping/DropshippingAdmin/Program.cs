using DropshippingAdmin.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicione o contexto do banco de dados
builder.Services.AddDbContext<DropshippingAdminContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DropshippingAdminDatabase")));

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
