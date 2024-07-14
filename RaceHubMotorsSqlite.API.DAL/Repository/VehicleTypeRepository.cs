using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

/// <summary>
/// Initializes an instance of <see cref="VehicleTypeRepository"/>.
/// </summary>
/// <param name="motorsContext">The database context injection.</param>
public class VehicleTypeRepository(MotorsContext motorsContext) : IVehicleTypeRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    /// <summary>
    /// This method implementation will get all the vehicle types.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
    public async Task<List<VehicleType>> GetAllVehicleTypesAsync()
    {
        var results = await this.motorsContext.VehicleTypes.ToListAsync();
        return results!;
    }

    /// <summary>
    /// This method implementation will get a single vehicle type from the database.
    /// </summary>
    /// <param name="code">The code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    public async Task<VehicleType> GetVehicleTypeByCodeAsync(string code)
    {
        var result = await this.motorsContext.VehicleTypes.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    /// <summary>
    /// This method implementation will get a single vehicle type from the database.
    /// </summary>
    /// <param name="id">The primary key - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    public async Task<VehicleType> GetVehicleTypeByIdAsync(int id)
    {
        var result = await this.motorsContext.VehicleTypes.FirstOrDefaultAsync(g => g.VehicleTypeId == id);
        return result!;
    }

    /// <summary>
    /// This method implementation will add a new vehicle type to the database.
    /// </summary>
    /// <param name="vehicleType">The vehicle type information to add.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    public async Task<VehicleType> AddVehicleTypeAsync(VehicleType vehicleType)
    {
        this.motorsContext.VehicleTypes.Add(vehicleType);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? vehicleType : null!;
    }
}