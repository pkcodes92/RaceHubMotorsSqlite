using RaceHubMotorsSqlite.API.DTO.Models;

namespace RaceHubMotorsSqlite.API.Services.Interfaces;

public interface IVehicleColorService
{
    Task<List<VehicleColor>> GetVehicleColorsAsync();
}