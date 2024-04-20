using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

public interface IManufacturerRepository
{
    Task<List<Manufacturer>> GetAllManufacturersAsync();

    Task<Manufacturer> GetManufacturerAsync(int id);

    Task<Manufacturer> GetManufacturerAsync(string name);

    Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer);
}