using RaceHubMotorsSqlite.API.DTO;
using RaceHubMotorsSqlite.API.DTO.Models;

namespace RaceHubMotorsSqlite.API.Services.Interfaces;

public interface IVehicleTypeService
{
    Task<List<VehicleType>> GetVehicleTypesAsync();
}
