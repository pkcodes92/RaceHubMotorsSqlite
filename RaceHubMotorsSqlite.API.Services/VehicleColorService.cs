using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.Services.Interfaces;

namespace RaceHubMotorsSqlite.API.Services;

/// <summary>
/// Initializes an instance of <see cref="VehicleColorService"/>.
/// </summary>
/// <remarks>This class implements the necessary methods defined in <see cref="IVehicleColorService"/>.</remarks>
/// <param name="vehicleColorRepo">The vehicle color repository injection.</param>
public class VehicleColorService(IVehicleColorRepository vehicleColorRepo) 
: IVehicleColorService
{
    private readonly IVehicleColorRepository vehicleColorRepo = vehicleColorRepo;

    /// <summary>
    /// This method implementation will get a single vehicle color from the database.
    /// </summary>
    /// <param name="id">The primary key of the <see cref="VehicleColor"/> entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    public async Task<VehicleColor> GetVehicleColorAsync(int id)
    {
        var dbResult = await this.vehicleColorRepo.GetVehicleColorAsync(id);

        return new VehicleColor
        {
            Id = dbResult.VehicleColorId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method will get a single vehicle color from the database.
    /// </summary>
    /// <param name="code">The code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    public async Task<VehicleColor> GetVehicleColorAsync(string code)
    {
        var dbResult = await this.vehicleColorRepo.GetVehicleColorAsync(code);

        return new VehicleColor
        {
            Id = dbResult.VehicleColorId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will get all the vehicle colors from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
    public async Task<List<VehicleColor>> GetVehicleColorsAsync()
    {
        var dbResults = await this.vehicleColorRepo.GetAllVehicleColorsAsync();

        var results = new List<VehicleColor>();

        foreach (var item in dbResults)
        {
            var itemToAdd = new VehicleColor
            {
                Id = item.VehicleColorId,
                Code = item.Code,
                Description = item.Description
            };

            results.Add(itemToAdd);
        }

        return results!;
    }
}