using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

public interface IVehicleColorRepository
{
    Task<List<VehicleColor>> GetAllVehicleColorsAsync();

    Task<VehicleColor> GetVehicleColorAsync(int vehicleColorId);

    Task<VehicleColor> GetVehicleColorAsync(string code);

    Task<VehicleColor> AddVehicleColorAsync(VehicleColor vehicleColor);
}