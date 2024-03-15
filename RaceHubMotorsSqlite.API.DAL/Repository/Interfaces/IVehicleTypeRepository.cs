using RaceHubMotorsSqlite.API.DAL.Models;

public interface IVehicleTypeRepository
{
    Task<List<VehicleType>> GetAllVehicleTypesAsync();

    Task<VehicleType> GetVehicleTypeByIdAsync(int id);

    Task<VehicleType> GetVehicleTypeByCodeAsync(string code);
}