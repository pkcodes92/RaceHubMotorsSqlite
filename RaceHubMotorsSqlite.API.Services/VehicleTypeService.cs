using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.Services.Interfaces;

namespace RaceHubMotorsSqlite.API.Services;

public class VehicleTypeService(IVehicleTypeRepository vehicleTypeRepo) : IVehicleTypeService
{
    private readonly IVehicleTypeRepository vehicleTypeRepo = vehicleTypeRepo;

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
