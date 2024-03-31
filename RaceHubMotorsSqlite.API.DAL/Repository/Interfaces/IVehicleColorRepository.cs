using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

public interface IVehicleColorRepository
{
    Task<List<VehicleColor>> GetAllVehicleColorsAsync();

    Task<VehicleColor> GetVehicleColorByIdAsync(int vehicleColorId);

    Task<VehicleColor> GetVehicleColorByCodeAsync(string code);
}