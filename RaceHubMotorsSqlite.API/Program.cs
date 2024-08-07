using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Repository;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.Services;
using RaceHubMotorsSqlite.API.Services.Interfaces;

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

#region Service injections
builder.Services.AddTransient<IVehicleTypeService, VehicleTypeService>();
builder.Services.AddTransient<IVehicleColorService, VehicleColorService>();
#endregion

#region Repository injections
builder.Services.AddTransient<IVehicleTypeRepository, VehicleTypeRepository>();
builder.Services.AddTransient<IVehicleColorRepository, VehicleColorRepository>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();