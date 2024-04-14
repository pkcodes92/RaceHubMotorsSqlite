using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

public class VehicleColorRepository(MotorsContext motorsContext) : IVehicleColorRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<List<VehicleColor>> GetAllVehicleColorsAsync()
    {
        var results = await this.motorsContext.VehicleColors.ToListAsync();
        return results;
    }

    public async Task<VehicleColor> GetVehicleColorByCodeAsync(string code)
    {
        var result = await this.motorsContext.VehicleColors.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    public async Task<VehicleColor> GetVehicleColorByIdAsync(int vehicleColorId)
    {
        var result = await this.motorsContext.VehicleColors.FirstOrDefaultAsync(g => g.VehicleColorId == vehicleColorId);
        return result!;
    }

    public async Task<VehicleColor> AddVehicleColorAsync(VehicleColor vehicleColor)
    {
        this.motorsContext.VehicleColors.Add(vehicleColor);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? vehicleColor : null!;
    }
}