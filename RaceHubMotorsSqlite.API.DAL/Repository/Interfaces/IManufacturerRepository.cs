using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

public interface IManufacturerRepository
{
    Task<List<Manufacturer>> GetAllManufacturersAsync();

    Task<Manufacturer> GetManufacturerByIdAsync(int id);

    Task<Manufacturer> GetManufacturerByNameAsync(string name);
}