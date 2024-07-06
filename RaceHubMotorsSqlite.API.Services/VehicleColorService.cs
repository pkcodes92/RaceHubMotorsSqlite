using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.Services.Interfaces;

namespace RaceHubMotorsSqlite.API.Services;

public class VehicleColorService(IVehicleColorRepository vehicleColorRepo) : IVehicleColorService
{
    private readonly IVehicleColorRepository vehicleColorRepo = vehicleColorRepo;

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