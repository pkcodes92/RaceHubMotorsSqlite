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