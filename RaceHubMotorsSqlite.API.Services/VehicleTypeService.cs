using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.Services.Interfaces;

namespace RaceHubMotorsSqlite.API.Services;

/// <summary>
/// Initializes an instance of <see cref="VehicleTypeService"/>.
/// </summary>
/// <remarks>This class implements the methods defined in <see cref="IVehicleTypeService"/>.</remarks>
/// <param name="vehicleTypeRepo">The necessary vehicle type repository injection.</param>
public class VehicleTypeService(IVehicleTypeRepository vehicleTypeRepo) 
    : IVehicleTypeService
{
    private readonly IVehicleTypeRepository vehicleTypeRepo = vehicleTypeRepo;

    /// <summary>
    /// This method implementation will retrieve a single vehicle type from the database.
    /// </summary>
    /// <param name="id">The primary key of the <see cref="VehicleType"/> - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    public async Task<VehicleType> GetVehicleTypeAsync(int id)
    {
        var dbResult = await this.vehicleTypeRepo.GetVehicleTypeAsync(id);

        return new VehicleType
        {
            Id = dbResult.VehicleTypeId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will retrieve a single vehicle type from the database.
    /// </summary>
    /// <param name="code">The necessary vehicle type code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    public async Task<VehicleType> GetVehicleTypeAsync(string code)
    {
        var dbResult = await this.vehicleTypeRepo.GetVehicleTypeAsync(code);

        return new VehicleType
        {
            Id = dbResult.VehicleTypeId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };

    }

    /// <summary>
    /// This method implementation will get all the vehicle types from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
    public async Task<List<VehicleType>> GetVehicleTypesAsync()
    {
        var dbResults = await this.vehicleTypeRepo.GetAllVehicleTypesAsync();

        var results = new List<VehicleType>();

        foreach (var result in dbResults)
        {
            var itemToAdd = new VehicleType
            {
                Id = result.VehicleTypeId,
                Code = result.Code,
                Description = result.Description
            };

            results.Add(itemToAdd);
        }

        return results;
    }
}
