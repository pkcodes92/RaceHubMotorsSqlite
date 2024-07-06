using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

/// <summary>
/// Intializes an instance of <see cref="ManufacturerRepository"/>.
/// </summary>
/// <remarks>This class implements the methods defined in <see cref="IManufacturerRepository"/>.</remarks>
/// <param name="motorsContext">The motors database context injection.</param>
public class ManufacturerRepository(MotorsContext motorsContext) : IManufacturerRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    /// <summary>
    /// This method implementation will add a new manufacturer to the database.
    /// </summary>
    /// <param name="manufacturer">The new manufacturer information to be added.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    public async Task<Manufacturer> AddManufacturerAsync(Manufacturer manufacturer)
    {
        this.motorsContext.Manufacturers.Add(manufacturer);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? manufacturer! : null!;
    }

    /// <summary>
    /// This method implementation will get all of the manufacturers from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Manufacturer"/>.</returns>
    public async Task<List<Manufacturer>> GetAllManufacturersAsync()
    {
        var results = await this.motorsContext.Manufacturers.ToListAsync();
        return results!;
    }

    /// <summary>
    /// This method will get a single manufacturer from the database.
    /// </summary>
    /// <param name="id">The primary key of the manufacturer entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    public async Task<Manufacturer> GetManufacturerAsync(int id)
    {
        var result = await this.motorsContext.Manufacturers.FirstOrDefaultAsync(g => g.ManufacturerId == id);
        return result!;
    }

    /// <summary>
    /// This method will get a single manufacturer from the database.
    /// </summary>
    /// <param name="name">The name of the manufacturer to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Manufacturer"/>.</returns>
    public async Task<Manufacturer> GetManufacturerAsync(string name)
    {
        var result = await this.motorsContext.Manufacturers.FirstOrDefaultAsync(g => g.Name == name);
        return result!;
    }
}