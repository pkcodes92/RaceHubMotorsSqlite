using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

public class VehicleTypeRepository(MotorsContext motorsContext) : IVehicleTypeRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<List<VehicleType>> GetAllVehicleTypesAsync()
    {
        var results = await motorsContext.VehicleTypes.ToListAsync();
        return results!;
    }

    public async Task<VehicleType> GetVehicleTypeByCodeAsync(string code)
    {
        var result = await motorsContext.VehicleTypes.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    public async Task<VehicleType> GetVehicleTypeByIdAsync(int id)
    {
        var result = await motorsContext.VehicleTypes.FirstOrDefaultAsync(g => g.VehicleTypeId == id);
        return result!;
    }
}