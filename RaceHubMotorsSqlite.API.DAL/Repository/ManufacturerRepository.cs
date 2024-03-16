using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.DAL.Repository;

public class ManufacturerRepository(MotorsContext motorsContext) : IManufacturerRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<List<Manufacturer>> GetAllManufacturersAsync()
    {
        var results = await this.motorsContext.Manufacturers.ToListAsync();
        return results!;
    }

    public async Task<Manufacturer> GetManufacturerByIdAsync(int id)
    {
        var result = await this.motorsContext.Manufacturers.FirstOrDefaultAsync(g => g.ManufacturerId == id);
        return result!;
    }

    public async Task<Manufacturer> GetManufacturerByNameAsync(string name)
    {
        var result = await this.motorsContext.Manufacturers.FirstOrDefaultAsync(g => g.Name == name);
        return result!;
    }
}