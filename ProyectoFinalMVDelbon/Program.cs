using Microsoft.EntityFrameworkCore;
using ProyectoFinalMVDelbon.Application.Services;
using ProyectoFinalMVDelbon.Application.Services.Interfaces;
using ProyectoFinalMVDelbon.InfraestructureData.Data;
using ProyectoFinalMVDelbon.InfraestructureData.Repository;
using ProyectoFinalMVDelbonDomain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IFichaClienteRepository), typeof(FichaClienteRepository));
builder.Services.AddScoped(typeof(IRegistroRepository), typeof(RegistroRepository));
builder.Services.AddScoped(typeof(IUsuarioClienteRepository), typeof(UsuarioClienteRepository));
builder.Services.AddScoped(typeof(IUsuarioSalonRepository), typeof(UsuarioSalonRepository));

builder.Services.AddScoped(typeof(IFichaService), typeof(FichaService));
builder.Services.AddScoped(typeof(IRegistroService), typeof(RegistroService));
builder.Services.AddScoped(typeof(IUsuarioSalonService), typeof(UsuarioSalonService));
builder.Services.AddScoped(typeof(IUsuarioClienteService), typeof(UsuarioClienteService));


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

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
