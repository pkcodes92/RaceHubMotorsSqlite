using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

/// <summary>
/// Initializes an instance of <see cref="VehicleColorRepository"/>.
/// </summary>
/// <param name="motorsContext">The motors database context injection.</param>
public class VehicleColorRepository(MotorsContext motorsContext) : IVehicleColorRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    /// <summary>
    /// This method implementation gets all of the vehicle colors from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
    public async Task<List<VehicleColor>> GetAllVehicleColorsAsync()
    {
        var results = await this.motorsContext.VehicleColors.ToListAsync();
        return results;
    }

    /// <summary>
    /// This method implementation gets a single vehicle color from the database.
    /// </summary>
    /// <param name="code">The necessary code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    public async Task<VehicleColor> GetVehicleColorAsync(string code)
    {
        var result = await this.motorsContext.VehicleColors.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    /// <summary>
    /// This method implementation will get a single vehicle color from the database.
    /// </summary>
    /// <param name="vehicleColorId">The vehicle color ID - the primary key.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    public async Task<VehicleColor> GetVehicleColorAsync(int vehicleColorId)
    {
        var result = await this.motorsContext.VehicleColors.FirstOrDefaultAsync(g => g.VehicleColorId == vehicleColorId);
        return result!;
    }

    /// <summary>
    /// This method implementation will add a new vehicle color to the database.
    /// </summary>
    /// <param name="vehicleColor">The new vehicle color information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    public async Task<VehicleColor> AddVehicleColorAsync(VehicleColor vehicleColor)
    {
        this.motorsContext.VehicleColors.Add(vehicleColor);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? vehicleColor : null!;
    }
}