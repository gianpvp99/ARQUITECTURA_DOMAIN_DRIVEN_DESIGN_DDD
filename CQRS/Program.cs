using CQRS.Application.DTOs.Mappers;
using CQRS.Application.Querys;
using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.Data;
using CQRS.Infrastructure.Repositories;
using CQRS.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Configurar EF Core con SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblyContaining<GetAllUserQuery>()
);

// Registrar AutoMapper para el ensamblado específico donde están los perfiles
builder.Services.AddAutoMapper(typeof(ConfigurationMapper).Assembly);

// Registrar repositorios y servicios de infraestructura
builder.Services.AddTransient<IUserRepository, UserRepository>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseRequestTiming(); //Middleware para medir tiempo de respuesta

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
