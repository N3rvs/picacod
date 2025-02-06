using Backend.Data;
using Backend.DTOs;
using Backend.Validadores;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Entity framework
builder.Services.AddDbContext<StoreContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("StoreConetions")));

//Validadores
builder.Services.AddScoped<IValidator<BeerInsertDto>,BeerInsertValidador>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
