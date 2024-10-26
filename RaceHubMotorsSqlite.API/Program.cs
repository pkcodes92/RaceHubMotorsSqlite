using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Repository;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.Services;
using RaceHubMotorsSqlite.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.EnableAnnotations();

    options.SwaggerDoc("v1", new OpenApiInfo{
        Title = "RaceHub Motors API",
        Version = "v1",
        Description = "An ASP.NET Core API using SQLite",
        Contact = new OpenApiContact
        {
            Name = "Pranav Krishnamurthy",
            Email = "pkrish19@outlook.com"
        }
    });
});
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("FileLocation");
builder.Services.AddDbContext<MotorsContext>(options => {
    options.UseSqlite(connectionString);
});

#region Service injections
builder.Services.AddTransient<IDrivetrainService, DrivetrainService>();
builder.Services.AddTransient<IVehicleTypeService, VehicleTypeService>();
builder.Services.AddTransient<IVehicleColorService, VehicleColorService>();
#endregion

#region Repository injections
builder.Services.AddTransient<IDrivetrainRepository, DrivetrainRepository>();
builder.Services.AddTransient<IVehicleTypeRepository, VehicleTypeRepository>();
builder.Services.AddTransient<IVehicleColorRepository, VehicleColorRepository>();
#endregion

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();