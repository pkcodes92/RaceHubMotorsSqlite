using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Manufacturer database entity.
/// </summary>
public interface IManufacturerRepository
{
    /// <summary>
    /// This method definition gets all of the manufactureres from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    Task<List<Manufacturer>> GetAllManufacturersAsync();

    /// <summary>
    /// This method definition will get a single manufacturer from the database.
    /// </summary>
    /// <param name="id">The primary key of the Manufacturer entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    Task<Manufacturer> GetManufacturerAsync(int id);

    /// <summary>
    /// This method definition will get a single manufacturer from the database.
    /// </summary>
    /// <param name="name">The name of the manufacturer.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    Task<Manufacturer> GetManufacturerAsync(string name);

    /// <summary>
    /// This method definition adds a new manufacturer to the database.
    /// </summary>
    /// <param name="manufacturer">The new manufacturer information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer);
}