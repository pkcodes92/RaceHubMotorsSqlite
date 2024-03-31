using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

public interface IVehicleTypeRepository
{
    Task<List<VehicleType>> GetAllVehicleTypesAsync();

    Task<VehicleType> GetVehicleTypeByIdAsync(int id);

    Task<VehicleType> GetVehicleTypeByCodeAsync(string code);
}