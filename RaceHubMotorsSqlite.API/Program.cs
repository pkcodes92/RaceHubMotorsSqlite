using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Repository;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("FileLocation");
builder.Services.AddDbContext<MotorsContext>(options => {
    options.UseSqlite(connectionString);
});

builder.Services.AddTransient<IVehicleTypeRepository, VehicleTypeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();